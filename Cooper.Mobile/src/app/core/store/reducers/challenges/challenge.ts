import { createReducer } from "@ngrx/store";
import { Challenge } from "src/app/core/models";


const initialState:Challenge[] = []; 

const ChallengeReducer = createReducer(initialState);

export {ChallengeReducer};