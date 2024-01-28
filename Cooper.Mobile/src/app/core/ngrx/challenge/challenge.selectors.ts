import { createFeatureSelector, createSelector } from "@ngrx/store";
import * as fromChallenge from './challenge.reducers';

export const selectChallengeState = createFeatureSelector<fromChallenge.State>(fromChallenge.challengeFeatureKey);

export const selectChallenges = createSelector(selectChallengeState,(state:fromChallenge.State)=>{
  return state.challenges
})

export const selectActiveChallenge = createSelector(selectChallengeState,(state)=>state.activeChallenge);
