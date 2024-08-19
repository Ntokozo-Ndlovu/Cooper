import { Injectable } from '@angular/core';
import { HttpGatewayService } from '../http';
import { Observable } from 'rxjs';
import { ChallengeListResponse } from 'src/app/core/interface/http/challenge';

@Injectable({
  providedIn: 'root'
})
export class ChallengeService {

  constructor(private httpGateway:HttpGatewayService) { }

  public fetchChallenges():Observable<ChallengeListResponse>{
    return this.httpGateway.get(`challenge`)
  }
}
