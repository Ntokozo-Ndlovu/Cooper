import { Component, OnInit} from '@angular/core';
import { Router } from '@angular/router';
import { Store } from '@ngrx/store';
import { Observable } from 'rxjs';
import { Post } from 'src/app/core/models';

import * as fromPost from 'src/app/core/ngrx/post'
@Component({
  selector: 'app-challenge-posts',
  templateUrl: './challenge-posts.component.html',
  styleUrls: ['./challenge-posts.component.scss'],
})
export class ChallengePostsComponent  implements OnInit {
  posts$?:Observable<Post[]>
  constructor(private router:Router,
    private store:Store) {
  }

  ngOnInit() {
    const currentNavigation = this.router.getCurrentNavigation();
    if(currentNavigation && currentNavigation.extras.state){
      const state = currentNavigation.extras.state;
      const challengeId = state['challengeId'];
      if(challengeId){
        this.store.dispatch(fromPost.fromActions.reqPostsForChallenge({challengeId}))
      }
    }

    this.posts$ = this.store.select(fromPost.fromSelectors.selectPostForChallenge);

  }

}
