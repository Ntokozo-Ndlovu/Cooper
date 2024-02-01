import { HttpStatusCode } from "@angular/common/http"

export interface LoginRequest {
  username: string,
  password: string
}


export interface LoginResponse {
  userId: string,
  statusCode: HttpStatusCode,
  message: string
}
