import { Action, createReducer, on } from "@ngrx/store";
import { Post } from "../../models";
import * as fromActions from './post.action'
import { keyframes } from "@angular/animations";
import { act } from "@ngrx/effects";

export const postFeatureKey = 'Post';

export interface State {
  posts: Post[],
  activeChallengePosts: Post[]
}

const initialState: State = {
  posts: [],
  activeChallengePosts: []
}

const postReducer = createReducer(initialState,
  on(fromActions.reqPostsSuccessful, (state, action) => {
    const newState = { ...state, posts: action.posts }
    return newState
  }),
  on(fromActions.reqPostsForChallenge, (state, action) => {
    const activeChallengePosts: Post[] = state.posts.filter((post) => post.challengeId == action.challengeId)
    const newState = { ...state, activeChallengePosts };
    return newState;
  }),
  on(fromActions.reqLikePostSuccessful, (state, action) => {
    const posts = [...state.posts]
    const activeChallengePosts = [...state.activeChallengePosts];

    const postIndex = posts.findIndex(x => x.postId == action.like.postId)
    if (postIndex > -1)
      posts[postIndex] = { ...posts[postIndex], like: posts[postIndex].like ? posts[postIndex].like : 0 };

    const activePostIndex = activeChallengePosts.findIndex(x => x.postId == action.like.postId);
    if (activePostIndex > -1)
      activeChallengePosts[activePostIndex] = {
        ...activeChallengePosts[activePostIndex],
        like: activeChallengePosts[activePostIndex].like ? activeChallengePosts[activePostIndex].like : 0
      };

    const newState = { ...state, posts, activeChallengePosts }
    return newState;
  }),
  on(fromActions.reqRemoveLikeOnPostSuccessful, (state, action) => {
    const posts = [...state.posts]
    const activeChallengePosts = [...state.activeChallengePosts];

    const postIndex = posts.findIndex(x => x.postId == action.like.postId)
    if (postIndex > -1)
      posts[postIndex] = {
        ...posts[postIndex],
        like: posts[postIndex].like
      };

    const activePostIndex = activeChallengePosts.findIndex(x => x.postId == action.like.postId);
    if (activePostIndex > -1)
      activeChallengePosts[activePostIndex] = {
        ...activeChallengePosts[activePostIndex],
        like: activeChallengePosts[activePostIndex].like
      };

    const newState = { ...state, posts, activeChallengePosts }
    return newState;
  }),
  on(fromActions.reqFetchNumberOfLikesSuccesful, (state, action) => {
    const postIndex = state.posts.findIndex(post => post.postId == action.postId)
    let posts = [...state.posts]
    if (postIndex > -1) {
      posts[postIndex] = { ...posts[postIndex], like: action.likes }
    }

    const activePostIndex = state.posts.findIndex(post => post.postId == action.postId)
    let activePosts = [...state.activeChallengePosts]
    if (activePostIndex > -1) {
      activePosts[activePostIndex] = { ...activePosts[activePostIndex], like: action.likes }
    }
    return { activeChallengePosts: activePosts, posts: posts }
  })
)

export const reducer = (state = initialState, action: Action) => {
  return postReducer(state, action)
}

