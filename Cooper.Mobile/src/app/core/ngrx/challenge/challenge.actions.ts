import { createAction , props} from "@ngrx/store";
import { Challenge } from "src/app/core/models";


export const reqChallenges = createAction("[Challenge Page] Req challenges from backend");

export const reqChallengesSuccess = createAction("[Challenge Page] Req challenges successful", props<{challenges:Challenge[]}>());

export const reqViewChallenge = createAction("[Challenge Page] view challenge details", props<{challengeId:string}>())
