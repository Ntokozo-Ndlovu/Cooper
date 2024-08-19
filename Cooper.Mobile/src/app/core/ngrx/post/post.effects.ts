import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { fromActions } from ".";
import { catchError, mergeMap, switchMap } from "rxjs";
import { PostService } from "../../services/api/post";

@Injectable()
export class PostEffects{
  reqPost$ = createEffect(()=>{
    return this.actions$
    .pipe(
      ofType(fromActions.reqPosts),
      switchMap(()=>{
        return this.post.getAllPosts()
        .pipe(
          mergeMap((response)=>{

            return [fromActions.reqPostsSuccessful({posts:response.posts})]
          })
        )
      })
    )
  })

  reqFetchNumberOfLikes$ = createEffect(()=>this.actions$.pipe(
    ofType(fromActions.reqFetchNumberOfLikes),
    mergeMap(({postId})=>{
      return this.post.getLikesForPost(postId).pipe(
        mergeMap((response)=>{
          console.log("Likes: ", response)
            return [fromActions.reqFetchNumberOfLikesSuccesful({postId:response.likes.postId, likes: response.likes.likes})]
          }),
        catchError((err)=>{
          console.log("error stus")
            return []
        })

      )
    })
  ))


  reqLikePost$ = createEffect(()=>{
    return this.actions$
    .pipe(
      ofType(fromActions.reqLikePost),
      switchMap((action)=>{
        return this.post.likePost({userId:action.userId,postId:action.postId})
        .pipe(mergeMap((response)=>{
          const like = response.likes;
          return [fromActions.reqLikePostSuccessful({like:{userId:like.userId, username: like.username,postId:like.postId}})]
        }))
      })
      )
  })


  reqRemoveLikeOnPost$ = createEffect(()=>{
    return this.actions$
    .pipe(
      ofType(fromActions.reqRemoveLikeOnPost),
      switchMap((action)=>{
        return this.post.removeOnLikePost({userId:action.userId, postId:action.postId})
        .pipe(
          mergeMap((response)=>{
            const like = response.likes;
            return [fromActions.reqRemoveLikeOnPostSuccessful({like:{userId:like.userId, username: like.username,postId:like.postId}})]
          }))
      }))
  })

  constructor(private post:PostService, private actions$:Actions){

  }
}
