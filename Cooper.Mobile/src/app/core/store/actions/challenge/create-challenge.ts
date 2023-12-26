import { createAction ,props} from "@ngrx/store";
import { Challenge } from "src/app/core/models";

const createChallengeAction = createAction("[Challenge Page] create challenge",props<Challenge>())
const createChallengeActionSuccess = createAction("[Challenge Page] create challenge",props<Challenge>())

export {createChallengeActionSuccess,createChallengeAction}