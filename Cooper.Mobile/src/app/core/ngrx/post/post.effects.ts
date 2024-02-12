import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { fromActions } from ".";
import { mergeMap, switchMap } from "rxjs";
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
          mergeMap((posts)=>{
            return [fromActions.reqPostsSuccessful({posts})]
          })
        )
      })
    )
  })

  reqLikePost$ = createEffect(()=>{
    return this.actions$
    .pipe(
      ofType(fromActions.reqLikePost),
      switchMap((action)=>{
        return this.post.likePost({userId:action.userId,postId:action.postId})
        .pipe(mergeMap((response)=>{
          return [fromActions.reqLikePostSuccessful({like:response})]
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
            return [fromActions.reqRemoveLikeOnPostSuccessful({like:response})]
          }))
      }))
  })

  constructor(private post:PostService, private actions$:Actions){

  }
}
