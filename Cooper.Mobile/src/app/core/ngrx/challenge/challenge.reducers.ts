import { createReducer, on, Action } from "@ngrx/store"
import { Challenge } from "src/app/core/models"
import { reqChallenges, reqChallengesSuccess } from "./challenge.actions";


export const challengeFeatureKey = 'Challenge';

export interface State {
  challenges: Challenge[]
}

export const initialState:State = {
  challenges:[]
}

const challengeReducer = createReducer(initialState,
  on(reqChallenges,(state)=>{
  return state;
  }),
  on(reqChallengesSuccess,(state,action)=>{
    return {...state, challenges: action.challenges}
  }));


export const reducer = (state = initialState, action:Action)=>{
  return challengeReducer(state,action)
}
