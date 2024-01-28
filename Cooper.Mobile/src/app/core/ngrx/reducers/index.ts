import { ActionReducerMap } from '@ngrx/store';
import * as fromChallenge from '../challenge';
import * as fromPost from '../post';
//Export reducers


export interface State {
  [fromChallenge.challengeFeatureKey]:fromChallenge.ChallengeState,
  [fromPost.postFeatureKey]:fromPost.PostState
}

export const reducers:ActionReducerMap<State> = {
  [fromChallenge.challengeFeatureKey]: fromChallenge.challengeReducer,
  [fromPost.postFeatureKey]:fromPost.postReducer
}
