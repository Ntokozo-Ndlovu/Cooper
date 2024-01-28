import { Action, createReducer, on } from "@ngrx/store";
import { Post } from "../../models";
import * as fromActions from './post.action'

export const postFeatureKey = 'Post';

export interface State{
  posts:Post[]
}

const initialState:State = {
  posts:[]
}

const postReducer = createReducer(initialState,
  on(fromActions.reqPostsSuccessful,(state,{posts})=>{
    return {...state, posts}
  }))

export const reducer = (state= initialState, action:Action)=>{
    return postReducer(state,action)
  }

