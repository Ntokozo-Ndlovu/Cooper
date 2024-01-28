import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { HttpClient } from '@angular/common/http';
import { Store } from "@ngrx/store";
import * as fromChallenge from './'
import { mergeMap, switchMap } from "rxjs";
import { Challenge } from "../../models";

@Injectable()
export class ChallengeEffects {
  reqChallenges$ = createEffect(()=>{
    return this.actions$.pipe(
      ofType(fromChallenge.challengeActions.reqChallenges),
      switchMap(()=>{
        return this.http.get<Challenge[]>('https://localhost:7248/api/v1/challenge')
        .pipe(
          mergeMap((challenges)=>{
            return [fromChallenge.challengeActions.reqChallengesSuccess({challenges})]
          })
        )
      })
    )
  })

  constructor(private actions$:Actions,
    private http:HttpClient,
    private store:Store<fromChallenge.ChallengeState>){}
}
