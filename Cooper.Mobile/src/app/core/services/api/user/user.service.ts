import { GetUserResponse } from './../../../interface/http/user/user.interface';
import { Injectable } from '@angular/core';
import { HttpGatewayService } from '../http';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http:HttpGatewayService) { }

  public getUserInformation(userId:string){
    return this.http.get<GetUserResponse>(`user/${userId}`)
  }



}
