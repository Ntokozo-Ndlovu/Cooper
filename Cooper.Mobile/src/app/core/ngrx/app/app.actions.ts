import { createAction, props } from "@ngrx/store";


export const reqAppAuthenticatedSuccessful = createAction('[From Auth Effect] App authenticated',props<{userId:string}>())
