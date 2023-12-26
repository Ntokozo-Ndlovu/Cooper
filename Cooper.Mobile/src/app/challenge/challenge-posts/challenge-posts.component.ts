import { Component, OnInit,Input } from '@angular/core';
import { Post } from 'src/app/core/models';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-challenge-posts',
  templateUrl: './challenge-posts.component.html',
  styleUrls: ['./challenge-posts.component.scss'],
})
export class ChallengePostsComponent  implements OnInit {
  @Input() posts?:Observable<Post[]>;
  constructor() { 
  }

  ngOnInit() {}

}
