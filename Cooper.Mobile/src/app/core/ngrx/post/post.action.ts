import { createAction, props } from "@ngrx/store";
import { Post } from "../../models";

export const reqPosts = createAction('[Post Page] req post from back end');
export const reqPostsSuccessful = createAction('[Post Page] req posts from backend successful',props<{posts:Post[]}>())
