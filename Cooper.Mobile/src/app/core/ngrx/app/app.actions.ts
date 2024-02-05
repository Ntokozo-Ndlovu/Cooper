import { createAction, props } from "@ngrx/store";
import { User } from "../../models/user/user.model";


export const reqAppAuthenticatedSuccessful = createAction('[From Auth Effect] App authenticated',props<{userId:string}>())

export const reqUserInformation = createAction('[From Home Page] get user Information',props<{userId:string}>());

export const reqUserInformationSuccesful = createAction('[From Home Page] get user Information succesful',props<{user:User}>())

export const reqUserInformationFail = createAction('[From Home Page] get  user Information fail',props<{err:unknown}>())
