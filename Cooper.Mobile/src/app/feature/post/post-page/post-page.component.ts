import { Observable, distinctUntilChanged, take, takeUntil } from 'rxjs';
import { Component, EventEmitter, OnDestroy, OnInit } from '@angular/core';
import { Post } from 'src/app/core/models';
import { Store } from '@ngrx/store';
import * as fromPost from 'src/app/core/ngrx/post'

@Component({
  selector: 'app-post-page',
  templateUrl: './post-page.component.html',
  styleUrls: ['./post-page.component.scss'],
})
export class PostPageComponent  implements OnInit, OnDestroy{
  post$?:Observable<Post[]>;

  destroy$:EventEmitter<void> = new EventEmitter();
  constructor(private store:Store) { }

  ngOnInit() {
    this.post$ = this.store.select(fromPost.fromSelectors.selectPost);
    this.store.dispatch(fromPost.fromActions.reqPosts());

    this.post$.pipe(distinctUntilChanged((previousPost,currentPost)=>!this.postsChange(previousPost,currentPost)))
    .subscribe((posts)=>{
      posts.forEach(post=>{
      this.store.dispatch(fromPost.fromActions.reqFetchNumberOfLikes({postId:post.postId}))
      })
    })
  }


  private postsChange(previousPost:Post[],currentPost:Post[]):boolean{
      if(previousPost.length != currentPost.length)
        return true;
      const previousPostIds = Object.values(previousPost.map(post => post.postId)).sort();
      const currentPostIds = Object.values(currentPost.map(post => post.postId)).sort();
      if(JSON.stringify(previousPostIds) !== JSON.stringify(currentPostIds))
        return true;
      return false;

  }
  ngOnDestroy(): void {
    this.destroy$.emit();
  }
}
