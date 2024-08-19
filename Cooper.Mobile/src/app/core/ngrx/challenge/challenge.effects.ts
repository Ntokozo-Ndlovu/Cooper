import { Injectable } from "@angular/core";
import { Actions, createEffect, ofType } from "@ngrx/effects";
import { HttpClient } from '@angular/common/http';
import { Store } from "@ngrx/store";
import * as fromChallenge from './'
import { mergeMap, switchMap } from "rxjs";
import { Challenge } from "../../models";
import { ChallengeService } from "../../services/api/challenge/challenge.service";

@Injectable()
export class ChallengeEffects {
  reqChallenges$ = createEffect(()=>{
    return this.actions$.pipe(
      ofType(fromChallenge.challengeActions.reqChallenges),
      switchMap(()=>{
        return  this.challengeService.fetchChallenges().pipe(
          mergeMap((response)=>{
            return [fromChallenge.challengeActions.reqChallengesSuccess({challenges:response.challenges})]
          })
        )
      })
    )
  })

  constructor(private actions$:Actions,
    private challengeService:ChallengeService){}
}
