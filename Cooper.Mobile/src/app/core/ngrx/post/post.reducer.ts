import { Action, createReducer, on } from "@ngrx/store";
import { Post } from "../../models";
import * as fromActions from './post.action'

export const postFeatureKey = 'Post';

export interface State{
  posts:Post[],
  activeChallengePosts:Post[]
}

const initialState:State = {
  posts:[],
  activeChallengePosts:[]
}

const postReducer = createReducer(initialState,
  on(fromActions.reqPostsSuccessful,(state,action)=>{
    const newState = {...state,posts:action.posts}
    return newState
  }),
  on(fromActions.reqPostsForChallenge,(state,action)=>{
    const activeChallengePosts:Post[] = state.posts.filter((post)=> post.challengeId == action.challengeId)
    const newState = {...state, activeChallengePosts};
    console.log('New State: ', newState)
    return newState;
  }))

export const reducer = (state= initialState, action:Action)=>{
    return postReducer(state,action)
  }

