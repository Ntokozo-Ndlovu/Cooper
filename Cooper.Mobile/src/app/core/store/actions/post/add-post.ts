import { createAction , props} from "@ngrx/store";
import { Post } from 'src/app/core/models';

const addPostAction = createAction("[Challenge] add Post", props<Post>());
const addPostActionSuccess = createAction("[Challenge] add Post", props<Post>());

export { addPostAction, addPostActionSuccess}