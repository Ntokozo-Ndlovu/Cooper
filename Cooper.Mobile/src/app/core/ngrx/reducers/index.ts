import { ActionReducerMap } from '@ngrx/store';
import * as fromChallenge from '../challenge';
import * as fromPost from '../post';
import * as fromApp from '../app'
import * as fromAuth from '../auth'
//Export reducers


export interface State {
  [fromChallenge.challengeFeatureKey]:fromChallenge.ChallengeState,
  [fromPost.postFeatureKey]:fromPost.PostState,
  [fromApp.appFeatureKey]:fromApp.AppState,
  [fromAuth.authFeatureKey]:fromAuth.AuthState
}

export const reducers:ActionReducerMap<State> = {
  [fromChallenge.challengeFeatureKey]: fromChallenge.challengeReducer,
  [fromPost.postFeatureKey]:fromPost.postReducer,
  [fromApp.appFeatureKey]: fromApp.appReducer,
  [fromAuth.authFeatureKey]:fromAuth.authReducer
}
