import { createReducer , Action} from "@ngrx/store";


export const authFeatureKey = 'Auth';

export interface State {
  authenticated:boolean
}

const initialState:State = {
  authenticated:false
}

const authReducer = createReducer(initialState);



export const reducer = (state = initialState, actions:Action)=>{
  return authReducer(state,actions)
}
