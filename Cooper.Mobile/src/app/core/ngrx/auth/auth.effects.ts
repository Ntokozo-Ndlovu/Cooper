import { Injectable } from "@angular/core";
import { AuthService } from "../../services/api/auth";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { fromActions } from ".";
import {  catchError, map, mergeMap, of, switchMap } from "rxjs";

@Injectable()
export class AuthEffects {

  reqRegisterUser$ = createEffect(()=>{
    return this.actions$.pipe(
      ofType(fromActions.reqRegisterUser),
      switchMap(({userRequest})=>{
        return this.auth.register(userRequest)
        .pipe(
          mergeMap((response)=>{
            return [fromActions.reqRegisterUserSuccessful({userId:response.userID})]
          }),
          catchError((err)=>{            return of(err)
            .pipe(
              mergeMap((err)=>[fromActions.reqRegisterUserFail({message:err})]
              ))
          })
          )
      })
      )
  })

  reqLogin$ = createEffect(()=>{
    return this.actions$.pipe(
      ofType(fromActions.reqLoginUser),
      switchMap((action)=>{
        return this.auth.login(action.loginRequest).pipe(
          map((response)=>{
            return fromActions.reqLoginUserSuccessful({userId:response.userId})
          }),
          catchError(err=>{
            return of(err).pipe(
              map(()=> fromActions.reqLoginUserFail({message:err})))
          })
        )
      })
    )



  })


  constructor(private auth:AuthService, private actions$:Actions){

  }



}
