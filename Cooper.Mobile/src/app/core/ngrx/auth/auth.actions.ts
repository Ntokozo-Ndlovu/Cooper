import { Person, Password, Contact, Address } from './../../interface/http/auth/sign-up.interface';
import { LoginRequest } from './../../interface/http/auth/login.interface';
import { createAction, props } from "@ngrx/store";
import { SignUpRequest } from "../../interface/http/auth";


export const reqAuthenticated = createAction('[From Auth] check if user authenticated')

//Registering region
export const reqRegisterUser = createAction('[From Sign Up Page] Register a new user',props<{userRequest:SignUpRequest}>());

export const completePersonForm = createAction('[From SignUp Person Page] Person form complete',props<Partial<{username:string,person:Person,password:Password}>>());

export const validateFormPage = createAction('[From SignUp] Person form valid', props<{url:string,valid:boolean}>())

export const completeContactForm = createAction('[From SignUp Contact Page] Contact form complete',props<{contacts:Contact}>());

export const completeAddressForm = createAction('[From SignUp Address Page] Address form complete',props<{address:Address}>());

export const reqRegisterUserSuccessful = createAction('[From Auth Effects] Registering User successful',props<{userId:string}>());

export const reqRegisterUserFail = createAction('[From Auth Effect] Fail to register',props<{message:string}>());

//Login Regions
export const reqLoginUser = createAction('[From Login Page] Log user In', props<{loginRequest:LoginRequest}>());

export const reqLoginUserSuccessful = createAction('[From Auth Effect] Log user In successful',props<{userId:string}>());

export const reqLoginUserFail = createAction('[From Auth Effects] Log user In fail', props<{message:string}>())

//Logout Region
export const reqLogout = createAction('[From Home page] log user out');

