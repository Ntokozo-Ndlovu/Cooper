import { createFeatureSelector, createSelector } from "@ngrx/store";
import * as fromReducer from './auth.reducers';

const authFeatureState = createFeatureSelector<fromReducer.State>(fromReducer.authFeatureKey);

export const registerFormSelector = createSelector(authFeatureState,(state)=> state.registerForm);
