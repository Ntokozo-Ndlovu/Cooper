import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { IonicModule } from '@ionic/angular';
import {CommonModule} from "@angular/common";
import { PostCardComponent } from './components/post-card/post-card.component';
import { CommentsCardComponent } from './components/comments-card/comments-card.component';

@NgModule({
  declarations: [PostCardComponent, CommentsCardComponent],
  schemas:[CUSTOM_ELEMENTS_SCHEMA],
  imports: [
    IonicModule,
    CommonModule
  ],
  exports:[PostCardComponent, CommentsCardComponent]
})
export class CoreModule { }
