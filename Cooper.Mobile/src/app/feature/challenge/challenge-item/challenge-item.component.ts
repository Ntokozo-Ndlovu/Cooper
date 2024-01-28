import { Component, OnInit, Input } from '@angular/core';
import { Router } from '@angular/router';
import { Challenge } from 'src/app/core/models';

@Component({
  selector: 'app-challenge-item',
  templateUrl: './challenge-item.component.html',
  styleUrls: ['./challenge-item.component.scss'],
})
export class ChallengeItemComponent  implements OnInit {
  @Input() challenge?:Challenge;
  constructor(private router:Router) { }

  ngOnInit() {}

  handleViewPosts(challenge:Challenge| undefined){
    this.router.navigateByUrl('tabs/challenges/challenge-posts')
  }
}
