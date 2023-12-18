import { NgModule } from '@angular/core';
import { ChallengePageComponent } from './challenge-page/challenge-page.component';
import { ChallengeItemComponent } from './challenge-item/challenge-item.component';
import { IonicModule } from '@ionic/angular';
import { ChallengeRoutingModule } from './challenge-routing.module';
import { CoreModule } from '../core/core.module';
import { CommonModule } from '@angular/common';
import { ChallengePostsComponent } from './challenge-posts/challenge-posts.component';



@NgModule({
  declarations: [ChallengePageComponent,ChallengeItemComponent,ChallengePostsComponent],
  imports: [
    IonicModule,
    CoreModule,
    ChallengeRoutingModule,
    CommonModule
  ],
  exports:[ChallengePageComponent]
})
export class ChallengeModule { }
