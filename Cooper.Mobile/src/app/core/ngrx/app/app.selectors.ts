import { createFeatureSelector, createSelector } from "@ngrx/store"
import * as fromReducer from './app.reducers';

const appFeatureState = createFeatureSelector<fromReducer.State>(fromReducer.appFeatureKey);

export const selectAppAuthenticated = createSelector(appFeatureState,(state)=>state.authenticated);

export const selectAppUserId = createSelector(appFeatureState,(state)=> state.userId);

export const selectUser = createSelector(appFeatureState, (state)=> state.user);
