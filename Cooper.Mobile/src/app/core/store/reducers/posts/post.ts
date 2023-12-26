import { createReducer } from "@ngrx/store";
import { Post } from "src/app/core/models";

const initialPost:Post[] = [];

const PostReducer = createReducer(initialPost);

export {PostReducer};