import { HttpClient } from "@angular/common/http";
import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { fromActions } from ".";
import { mergeMap, switchMap } from "rxjs";
import { Post } from "../../models";

@Injectable()
export class PostEffects{
  reqPost$ = createEffect(()=>{
    return this.actions$
    .pipe(
      ofType(fromActions.reqPosts),
      switchMap(()=>{
        return this.http.get<Post[]>('https://localhost:7248/api/v1/post')
        .pipe(
          mergeMap((posts)=>{
            return [fromActions.reqPostsSuccessful({posts})]
          })
        )
      })
    )
  })

  constructor(private http:HttpClient, private actions$:Actions){

  }
}
