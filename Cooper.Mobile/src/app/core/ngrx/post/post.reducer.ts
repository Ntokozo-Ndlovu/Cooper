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
    return newState;
  }),
  on(fromActions.reqLikePostSuccessful,(state,action)=>{
    const posts = [...state.posts]
    const activeChallengePosts = [...state.activeChallengePosts];

    const postIndex = posts.findIndex(x => x.postId == action.like.postId)
    if(postIndex > -1)
    posts[postIndex] = {...posts[postIndex], like:posts[postIndex].like.concat(action.like)};

    const activePostIndex = activeChallengePosts.findIndex(x => x.postId == action.like.postId);
    if(activePostIndex > -1)
    activeChallengePosts[activePostIndex] = {...activeChallengePosts[activePostIndex], like:activeChallengePosts[activePostIndex].like.concat(action.like)};

    const newState = {...state,posts,activeChallengePosts }
    return newState;
  }),
  on(fromActions.reqRemoveLikeOnPostSuccessful,(state,action)=>{
    const posts = [...state.posts]
    const activeChallengePosts = [...state.activeChallengePosts];

    const postIndex = posts.findIndex(x => x.postId == action.like.postId)
    if(postIndex > -1)
    posts[postIndex]= {...posts[postIndex],
        like:posts[postIndex].like.filter(x => !(x.postId == action.like.postId && x.userId == action.like.userId))};

    const activePostIndex = activeChallengePosts.findIndex(x => x.postId == action.like.postId);
    if(activePostIndex > -1)
    activeChallengePosts[activePostIndex]= {...activeChallengePosts[activePostIndex],
  like:activeChallengePosts[activePostIndex].like.filter(x=> (x.postId == action.like.postId && x.userId == action.like.userId))};

    const newState = {...state,posts,activeChallengePosts }
    return newState;
  })
  )

export const reducer = (state= initialState, action:Action)=>{
    return postReducer(state,action)
  }

