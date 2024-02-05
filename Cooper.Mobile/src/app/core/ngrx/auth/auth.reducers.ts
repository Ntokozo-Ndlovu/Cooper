import { createReducer , Action, on} from "@ngrx/store";
import { SignUpRequest } from "../../interface/http/auth";
import * as fromActions from './auth.actions';

export const authFeatureKey = 'AuthState';

export interface State {
  registerForm:Partial<SignUpRequest>,
  signUpPages:{url:Readonly<string>,valid:boolean}[]
}

const initialState:State = {
  registerForm:{
    userName:'',
    address:{
      streetName:'',
      suburb:'',
      city:'',
      postalCode:''
    },
    contact:{
      email:'',
      phoneNumber:''
    },
    password:{password:''},
    person:{
      name:'',
      surname:'',
      age:0,
      gender:'male'
    },
  },
  signUpPages: [
    {url:'/auth/signup/sign-up-person',valid:false},
    {url:'/auth/signup/sign-up-address', valid:false},
    {url: '/auth/signup/sign-up-contact',valid:false}
  ]
}

const authReducer = createReducer(initialState,
  on(fromActions.completeAddressForm,(state,action)=>{
    const registerForm ={...state.registerForm,address:action.address};
    const newState = {...state, registerForm}

    return newState;

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

  }),
  on(fromActions.validateFormPage,(state,action)=>{
    const signUpPages = [...state.signUpPages];
    const pageIndex = signUpPages.findIndex((page)=> page.url == action.url);

    if(pageIndex < 0)
      return state;

    signUpPages[pageIndex] = {...signUpPages[pageIndex],valid:action.valid};
    const newState = {...state, signUpPages}
    return newState;

  })
);

export const reducer = (state = initialState, actions:Action)=>{
  return authReducer(state,actions)
}
