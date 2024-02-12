import { Injectable } from "@angular/core";
import { AuthService } from "../../services/api/auth";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import * as fromActions from "./auth.actions";
import {  catchError, map, mergeMap, of, switchMap, tap } from "rxjs";

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
          mergeMap((response)=>{
            if(response.userId == ''){
              throw {...response}
            }
            return [fromActions.reqLoginUserSuccessful({userId:response.userId})]
          }),
          catchError(err=>{
            return of(err).pipe(
              mergeMap(()=> [fromActions.reqLoginUserFail({message:err.message})]))
          })
        )
      })
    )



  })


  constructor(private auth:AuthService, private actions$:Actions){

  }



}
