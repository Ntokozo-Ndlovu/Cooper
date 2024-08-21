import { Component, OnInit, Input, OnDestroy, EventEmitter } from '@angular/core';
import { Store } from '@ngrx/store';
import { Post } from 'src/app/core/models';
import * as fromPost from 'src/app/core/ngrx/post';
import * as fromApp from 'src/app/core/ngrx/app'
import { takeUntil } from 'rxjs';

@Component({
  selector: 'app-post-card',
  templateUrl: './post-card.component.html',
  styleUrls: ['./post-card.component.scss'],
})
export class PostCardComponent implements OnInit, OnDestroy {
  @Input() post?: Post;
  private destroy$: EventEmitter<unknown> = new EventEmitter();

  constructor(private store: Store) { }

  ngOnInit() {
  }

  likePost() {
    if (this.post) {
     if(this.post.userLiked)
      this.store.dispatch(fromPost.fromActions.reqRemoveLikeOnPost({ postId: this.post.postId}))
      else
      this.store.dispatch(fromPost.fromActions.reqLikePost({ postId: this.post.postId}))
    }
  }


  commentOnPost() {
    console.log('Commented on Post')
  }

  sharePost() {
    console.log("Share the post")
  }

  ngOnDestroy() {
    this.destroy$.emit();
  }
}
