import { createAction, props } from "@ngrx/store";
import { Post } from "../../models";

export const reqPosts = createAction('[Post Page] req post from back end');
export const reqPostsSuccessful = createAction('[Post Page] req posts from backend successful',props<{posts:Post[]}>())
export const reqPostsForChallenge = createAction('[Challenge Page] set active posts',props<{challengeId:string}>());
export const reqPostsForChallengeSuccessful = createAction('[Challenge Page]')
