import { Action, createReducer, on } from "@ngrx/store";
import { Post } from "../../models";
import * as _ from "lodash"
import * as fromActions from './post.action'

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
    return { ...state, posts: action.posts }
  }),

  on(fromActions.reqPostsForChallenge, (state, action) => {
    const activeChallengePosts: Post[] = state.posts.filter((post) => post.challengeId == action.challengeId)
    const newState = { ...state, activeChallengePosts };

    return newState;

  }),

  on(fromActions.reqLikePostSuccessful, (state, action) => {
    const posts = _.cloneDeep(state.posts)
    const post = posts.find(x => x.postId == action.like.postId)
    if (post) {
      post.userLiked = true;
      post.like = post.like ? post.like + 1 : 0;
    }

    const activeChallengePosts = _.cloneDeep(state.activeChallengePosts);
    const activePost = activeChallengePosts.find(x => x.postId == action.like.postId);
    if (activePost) {
      activePost.userLiked = true,
        activePost.like = activePost.like ? activePost.like + 1 : 0;
    };

    return { ...state, posts, activeChallengePosts }
  }),

  on(fromActions.reqRemoveLikeOnPostSuccessful, (state, action) => {
    const posts = _.cloneDeep(state.posts)
    const post = posts.find(x => x.postId == action.like.postId)
    if (post) {
      post.userLiked = false;
      post.like = post.like ? post.like - 1 : 0;
    }

    const activeChallengePosts = _.cloneDeep(state.activeChallengePosts);
    const activePost = activeChallengePosts.find(x => x.postId == action.like.postId);
    if (activePost) {
      activePost.userLiked = false,
        activePost.like = activePost.like ? activePost.like - 1 : 0;
    };

    return { ...state, posts, activeChallengePosts }
  }),

  on(fromActions.reqFetchNumberOfLikesSuccesful, (state, action) => {
    let posts = _.cloneDeep(state.posts)
    const post = posts.find(post => post.postId == action.postId)
    if (post) {
      post.like = action.likes
    }

    let activePosts = _.cloneDeep(state.activeChallengePosts)
    const activePost = activePosts.find(post => post.postId == action.postId)
    if (activePost) {
      activePost.like  = action.likes }

    return { activeChallengePosts: activePosts, posts: posts }
  })
)

export const reducer = (state = initialState, action: Action) => {
  return postReducer(state, action)
}

