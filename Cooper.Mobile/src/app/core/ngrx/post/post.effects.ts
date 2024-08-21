import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { fromActions } from ".";
import { ReplaySubject, catchError, mergeMap, switchMap } from "rxjs";
import { PostService } from "../../services/api/post";
import * as fromApp from "src/app/core/ngrx/app"
import { Store } from "@ngrx/store";

@Injectable()
export class PostEffects {

  getUserId() {
    return this.store.select(fromApp.fromSelectors.selectAppUserId)
  }


  reqPost$ = createEffect(() => {
    return this.actions$
      .pipe(
        ofType(fromActions.reqPosts),
        switchMap(() => {
          return this.getUserId().pipe(
            mergeMap(
              (userId) => this.fetchAllPosts(userId)))
        }))
  })

  fetchAllPosts(userId: string) {
    {
      return this.post.getAllPosts(userId)
        .pipe(
          mergeMap((response) => {
            return [fromActions.reqPostsSuccessful({ posts: response.posts })]
          }))
    }
  }



  reqFetchNumberOfLikes$ = createEffect(() => this.actions$.pipe(
    ofType(fromActions.reqFetchNumberOfLikes),
    mergeMap(({ postId }) => {
      return this.post.getLikesForPost(postId).pipe(
        mergeMap((response) => {
          return [fromActions.reqFetchNumberOfLikesSuccesful({ postId: response.likes.postId, likes: response.likes.likes })]
        }),
        catchError((err) => {
          console.log("error stus")
          return []
        })

      )
    })
  ))


  reqLikePost$ = createEffect(() => {
    return this.actions$
      .pipe(
        ofType(fromActions.reqLikePost),
        switchMap(({ postId }) => {
          return this.getUserId().pipe(
            mergeMap((userId) => this.likePost(userId, postId)))
        })
      )
  })

  likePost(userId: string, postId: string) {
    return this.post.likePost({ userId, postId })
      .pipe(switchMap((response) => {
        const like = response.like;
        return [fromActions.reqLikePostSuccessful({ like: { userId: like.userId, username: like.username, postId: like.postId } })]
      }))
  }

  reqRemoveLikeOnPost$ = createEffect(() => {
    return this.actions$
      .pipe(
        ofType(fromActions.reqRemoveLikeOnPost),
        switchMap(({ postId }) => {
          return this.getUserId().pipe(
            switchMap((userId) => this.removeLikeFromPost(userId, postId)))

        }))
  })

  removeLikeFromPost(userId: string, postId: string) {
    return this.post.removeOnLikePost({ userId, postId })
      .pipe(
        mergeMap((response) => {
          const like = response.like;
          return [fromActions.reqRemoveLikeOnPostSuccessful({ like: { userId: like.userId, username: like.username, postId: like.postId } })]
        }))

  }
  constructor(private post: PostService, private store: Store, private actions$: Actions) {

  }
}
