import { createAction , props} from "@ngrx/store";
import { Post } from "src/app/core/models";

const createPostAction = createAction("[Challenge Page] create post",props<Post>());
const createPostActionSuccess = createAction("[Challenge Page] create post success");

export {createPostAction, createPostActionSuccess};