import { createAction, props } from "@ngrx/store";
import { Post } from "../../models";

export const reqPosts = createAction('[Post Page] req post from back end');
export const reqPostsSuccessful = createAction('[Post Page] req posts from backend successful',props<{posts:Post[]}>())

export const reqPostsForChallenge = createAction('[Challenge Page] set active posts',props<{challengeId:string}>());
export const reqPostsForChallengeSuccessful = createAction('[Challenge Page]')

export const reqLikePost = createAction('[Post Page] like a post', props<{userId:string,postId:string}>())
export const reqLikePostSuccessful = createAction('[Post Page] like a post successful',props<{like:{userId:string,postId:string,username:string}}>())

export const reqRemoveLikeOnPost = createAction('[Post Page] remove like a post', props<{userId:string,postId:string}>())
export const reqRemoveLikeOnPostSuccessful = createAction('[Post Page] remove like on post successful',props<{like:{userId:string,postId:string,username:string}}>())
