import { createReducer, on, Action } from "@ngrx/store"
import { Challenge } from "src/app/core/models"
import * as fromActions from "./challenge.actions";


export const challengeFeatureKey = 'Challenge';

export interface State {
  challenges: Challenge[],
  activeChallenge: Challenge | null
}

export const initialState:State = {
  challenges:[],
  activeChallenge: null
}

const challengeReducer = createReducer(initialState,
  on(fromActions.reqChallenges,(state)=>{
  return state;
  }),
  on(fromActions.reqChallengesSuccess,(state,action)=>{
    return {...state, challenges: action.challenges}
  }),
  on(fromActions.reqViewChallenge,(state,action)=>{
    const activeChallenge = state.challenges.find(challenge => challenge.id == action.challengeId);
    if(activeChallenge)
    return {...state, activeChallenge}
    return state;
  }));


export const reducer = (state = initialState, action:Action)=>{
  return challengeReducer(state,action)
}
