import { Observable } from 'rxjs';
import { Component, OnInit } from '@angular/core';
import { Post } from 'src/app/core/models';
import { Store } from '@ngrx/store';
import * as fromPost from 'src/app/core/ngrx/post'

@Component({
  selector: 'app-post-page',
  templateUrl: './post-page.component.html',
  styleUrls: ['./post-page.component.scss'],
})
export class PostPageComponent  implements OnInit {
  post?:Observable<Post[]>;
  constructor(private store:Store) { }

  ngOnInit() {
    this.post = this.store.select(fromPost.fromSelectors.selectPost);
    this.store.dispatch(fromPost.fromActions.reqPosts());
  }

}
