import { Action, createReducer, on } from "@ngrx/store"
import { fromActions } from ".";

export const appFeatureKey = 'AppState'

export interface State {
  authenticated:boolean
  userId:string
}

const initialState:State = {
  authenticated: false,
  userId:''
}


const appReducer = createReducer(initialState,
 // on(fromActions.reqAppAuthenticatedSuccessful, (state,action)=>{
  //  const newState = {...state, authenticated:true, userId:action.userId}
  //  return newState
  //})
  );


export const reducer = (state= initialState,action:Action)=>{
  return appReducer(state,action)
}
