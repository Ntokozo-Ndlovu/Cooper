import { Injectable } from '@angular/core';
import { HttpGatewayService } from '../http';
import { SignUpRequest } from 'src/app/core/interface/http/auth';
import { Observable } from 'rxjs';
import { SignUpResponse } from 'src/app/core/interface/http/auth/sign-up.interface';
import { LoginRequest, LoginResponse } from 'src/app/core/interface/http/auth/login.interface';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http:HttpGatewayService) { }

  register(registerRequest:SignUpRequest):Observable<SignUpResponse>{
    return this.http.post<SignUpResponse>('/register',registerRequest)
  }

  login(loginRequest:LoginRequest):Observable<LoginResponse>{
    return this.http.post<LoginResponse>('/login',loginRequest)
  }
}
