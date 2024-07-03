import { Action, createReducer, on } from "@ngrx/store"
import * as  fromActions  from "./app.actions";
import * as fromAuth from "../auth";
import { User } from "../../models/user/user.model";

export const appFeatureKey = 'AppState'

export interface State {
  authenticated:boolean
  userId:string,
  user:Partial<User>

}

const initialState:State = {
  authenticated: false,
  userId:'',
  user:{}
}


const appReducer = createReducer(initialState,
  on(fromActions.reqUserInformationSuccesful,(state,action)=>{
    const newState = {...state, user:action.user}
    return newState;
  }),
  on(fromAuth.fromActions.reqLoginUserSuccessful,(state,action)=>{
    const newState = {...state, userId:action.userId}
    return newState;
  }),
  on(fromAuth.fromActions.reqRegisterUserSuccessful,(state,action)=>{
    const newState = {...state, userId:action.userId}
    return newState;
  })

  );

export const reducer = (state= initialState,action:Action)=>{
  return appReducer(state,action)
}
