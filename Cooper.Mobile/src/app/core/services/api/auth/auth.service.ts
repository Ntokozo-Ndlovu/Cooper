import { Injectable } from '@angular/core';
import { HttpGatewayService } from '../http';
import { SignUpRequest } from 'src/app/core/interface/http/auth';
import { Observable, UnsubscriptionError } from 'rxjs';
import { SignUpResponse } from 'src/app/core/interface/http/auth/sign-up.interface';
import { LoginRequest, LoginResponse } from 'src/app/core/interface/http/auth/login.interface';
import { Person, Address, Contact } from 'src/app/core/models';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private http: HttpGatewayService) { }

  register(userName: string, password: string, person: Person, address: Address, contact: Contact): Observable<SignUpResponse> {
    const registerReq: SignUpRequest = { userName, password: { password: password }, person, address, contact }

    return this.http.post<SignUpResponse>('register', registerReq)
  }

  login(loginRequest: LoginRequest): Observable<LoginResponse> {
    return this.http.post<LoginResponse>('login', loginRequest)
  }
}
