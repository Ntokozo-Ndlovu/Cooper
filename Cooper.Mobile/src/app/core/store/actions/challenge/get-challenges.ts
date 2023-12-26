import { createAction } from "@ngrx/store";


const getAllChallengesAction = createAction("[Challenge Page] get all challenges")
const getAllChallengesActionSuccess = createAction("[Challenge Page] get all challenges success")
export { getAllChallengesAction, getAllChallengesActionSuccess};
