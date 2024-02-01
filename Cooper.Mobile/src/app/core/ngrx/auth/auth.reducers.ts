import { createReducer , Action, on} from "@ngrx/store";
import { SignUpRequest } from "../../interface/http/auth";
import * as fromActions from './auth.actions';

export const authFeatureKey = 'AuthState';

export interface State {
  registerForm:Partial<SignUpRequest>
}

const initialState:State = {
  registerForm:{}
}

const authReducer = createReducer(initialState,
  on(fromActions.completeAddressForm,(state,action)=>{
    const registerForm ={...state.registerForm,address:action.address};
    const newState = {...state, registerForm}
    return newState
  }),
  on(fromActions.completeContactForm,(state,action)=>{
    const registerForm = {...state.registerForm, contacts:action.contacts};
    const newState = {...state,registerForm};
    return newState;
  }),
  on(fromActions.completePersonForm,(state,action)=>{
    const registerForm = {...state.registerForm, userName:action.username ,person:action.person,password:action.password};
    const newState = {...state, registerForm};
    return newState;
  })
);

export const reducer = (state = initialState, actions:Action)=>{
  return authReducer(state,actions)
}
