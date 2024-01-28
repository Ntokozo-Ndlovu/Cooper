import { createFeatureSelector, createSelector } from "@ngrx/store";
import * as fromPost from './post.reducer'

const selectPostState = createFeatureSelector<fromPost.State>(fromPost.postFeatureKey);

export const selectPost = createSelector(selectPostState,(state)=> state.posts)
