import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import * as fromActions from './app.actions';
import { catchError, mergeMap, of, switchMap } from "rxjs";
import { UserService } from "../../services/api/user";


@Injectable()
export class AppEffects{


  reqFetchUserInformation$ = createEffect(()=>{
    return this.actions$
      .pipe(
        ofType(fromActions.reqUserInformation),
        switchMap(({userId})=>{
          return this.user.getUserInformation(userId)
            .pipe(
              mergeMap((user)=>{
                console.log('user', user)
                return [fromActions.reqUserInformationSuccesful({user})]
              }),
              catchError((err)=>{
                return of(err)
                .pipe(mergeMap((err)=>{
                  return [fromActions.reqUserInformationFail({err})]
                }))
              })
            )
        })
        )
  })


  constructor(private actions$:Actions,private user:UserService ){

  }
}
