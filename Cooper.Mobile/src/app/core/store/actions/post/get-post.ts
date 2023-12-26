import { createAction, props } from "@ngrx/store";
import { Post } from "src/app/core/models";

type GetAllPost = {
    posts: Post[]
}
const getPostsAction = createAction("[Challenge Page] get all Posts", props<GetAllPost>());
const getPostsActionSuccess = createAction("[Challenge Page] get all Posts success");

export {getPostsAction , getPostsActionSuccess}