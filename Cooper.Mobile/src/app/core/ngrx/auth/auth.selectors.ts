import { createFeatureSelector, createSelector } from "@ngrx/store";
import * as fromReducer from './auth.reducers';

const authFeatureState = createFeatureSelector<fromReducer.State>(fromReducer.authFeatureKey);

export const registerFormSelector = createSelector(authFeatureState,(state)=> state.registerForm);

export const personFormSelector = createSelector(authFeatureState,(state)=>{return  {person:state.registerForm.person,password:state.registerForm.password, userName:state.registerForm.userName}});

export const contactFormSelector = createSelector(authFeatureState,state => state.registerForm.contact);

export const addressFormSelector = createSelector(authFeatureState,state=> state.registerForm.address);
