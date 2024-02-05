import { Injectable } from '@angular/core';
import { HttpGatewayService } from '../http';
import { User } from 'src/app/core/models/user/user.model';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(private http:HttpGatewayService) { }

  public getUserInformation(userId:string){
    return this.http.get<User>(`user/${userId}`)
  }



}
