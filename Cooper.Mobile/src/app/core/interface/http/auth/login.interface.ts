import { HttpStatusCode } from "@angular/common/http"
import { ResponseBase } from "../common"

export interface LoginRequest {
  username: string,
  password: string
}


export interface LoginResponse extends ResponseBase {
  userId: string,
}
