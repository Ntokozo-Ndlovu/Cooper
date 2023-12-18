import { Component, OnInit } from '@angular/core';
import { Post } from 'src/app/core/models';
import { Observable } from 'rxjs';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'app-challenge-posts',
  templateUrl: './challenge-posts.component.html',
  styleUrls: ['./challenge-posts.component.scss'],
})
export class ChallengePostsComponent  implements OnInit {
  posts:Observable<Post[]>;
  constructor(private HttpClient:HttpClient) { 
    this.posts = this.HttpClient.get<Post[]>('assets/dummy-data.json');
  }

  ngOnInit() {}

}
