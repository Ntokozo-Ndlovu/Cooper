import { ActionReducerMap } from '@ngrx/store';
import * as fromChallenge from '../challenge';
import * as fromPost from '../post';
import * as fromApp from '../app';
//Export reducers


export interface State {
  [fromChallenge.challengeFeatureKey]:fromChallenge.ChallengeState,
  [fromPost.postFeatureKey]:fromPost.PostState
  [fromApp.appFeatureKey]:fromApp.AppState
}

export const reducers:ActionReducerMap<State> = {
  [fromChallenge.challengeFeatureKey]: fromChallenge.challengeReducer,
  [fromPost.postFeatureKey]:fromPost.postReducer,
  [fromApp.appFeatureKey]: fromApp.AppReducers
}
