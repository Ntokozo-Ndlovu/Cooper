import { NgModule } from '@angular/core';
import { RouterModule ,Routes} from '@angular/router';
import { ChallengePageComponent } from './challenge-page/challenge-page.component';
import { ChallengePostsComponent } from './challenge-posts/challenge-posts.component';

const path: Routes = [
  {path:'',
  component:ChallengePageComponent},
  {path:'challenge-posts',
  component:ChallengePostsComponent}
]

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild(path)
  ],
  exports:[RouterModule]
})
export class ChallengeRoutingModule { }
