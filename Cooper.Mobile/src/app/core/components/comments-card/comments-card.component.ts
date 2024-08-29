import { Input, Component, OnInit } from '@angular/core';
import { Comment, Post } from 'models';
import { CommentsService } from 'services/api/comments/comments.service';
import { Observable, map } from 'rxjs';

@Component({
  selector: 'app-comments-card',
  templateUrl: './comments-card.component.html',
  styleUrls: ['./comments-card.component.scss'],
})
export class CommentsCardComponent implements OnInit {

  @Input() post?: Post;
  comments?: Observable<Comment[]>;

  constructor(private commentsService: CommentsService) { }

  ngOnInit() {
    if (this.post)
      this.comments = this.commentsService.fetchComments(parseInt(this.post.postId))
    .pipe(map(x => x.comments));
  }

  commentTrackByFn(index: number, comment: Comment) {
    return comment.id;
  }
}
