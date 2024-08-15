import { createReducer , Action, on} from "@ngrx/store";
import * as fromActions from './auth.actions';
import { Person , Address, Contact} from "../../models";

export const authFeatureKey = 'AuthState';

export interface State {
  registerForm:{
    userName:string,
    address:Address,
    contact:Contact,
    person:Person,
    password:string
  },
  signUpPages:{url:Readonly<string>,valid:boolean}[],
  registeringLoading:boolean,
  userId:string,
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
    password:"",
    person:{
      name:'',
      surname:'',
      age:0,
      gender:'male'
    },
  },
  userId:'',
  registeringLoading:false,
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
    const registerForm = {...state.registerForm, userName:action.username, password:action.password ,person:action.person};
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

  }),
  on(fromActions.reqRegisterUser,(state)=>{
    const newState = {...state,  registeringLoading:true}
    return newState;
  }),
  on(fromActions.reqRegisterUserSuccessful,(state,action)=>{
    const userId = action.userId;
    const newState = {...state, registeringLoading:false, userId};
    return newState;
  }),
  on(fromActions.reqRegisterUserFail,(state)=>{
    const newState = {...state, registeringLoading:false};
    return newState;
  }),
  on(fromActions.reqLoginUserSuccessful,(state,action)=>{
    const newState = {...state, userId:action.userId};
    return newState;
  })
);

export const reducer = (state = initialState, actions:Action)=>{
  return authReducer(state,actions)
}
