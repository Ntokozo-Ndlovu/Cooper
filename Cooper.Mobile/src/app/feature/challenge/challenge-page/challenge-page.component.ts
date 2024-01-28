import { Observable } from 'rxjs';
import { Component, OnInit } from '@angular/core';
import { Store } from '@ngrx/store';
import { Challenge } from 'src/app/core/models';
import * as fromChallenge from 'src/app/core/ngrx/challenge';

@Component({
  selector: 'app-challenge-page',
  templateUrl: './challenge-page.component.html',
  styleUrls: ['./challenge-page.component.scss'],
})
export class ChallengePageComponent  implements OnInit {
  challenges?:Observable<Challenge[]>;
  constructor(private store:Store<fromChallenge.ChallengeState>) { }

  ngOnInit() {
    this.challenges = this.store.select(fromChallenge.challengeSelectors.selectChallenges);
    this.store.dispatch(fromChallenge.challengeActions.reqChallenges());
  }

}
