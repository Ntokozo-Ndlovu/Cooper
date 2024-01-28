import { createAction , props} from "@ngrx/store";
import { Challenge } from "src/app/core/models";


export const reqChallenges = createAction("[Challenge Page] Req challenges from backend");

export const reqChallengesSuccess = createAction("[Challenge Page] Req challenges successfull", props<{challenges:Challenge[]}>());

