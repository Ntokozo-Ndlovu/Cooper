import { createAction, props } from "@ngrx/store";
import { Challenge } from "src/app/core/models";
type ChallengeRequest = {
    challengeId:String
}


const getChallengeAction = createAction("[Challenge Page] get challenge",props<ChallengeRequest>())
const getChallengeActionSuccess = createAction("[Challenge Page] get challenge success",props<Challenge>())

export { getChallengeAction, getChallengeActionSuccess}