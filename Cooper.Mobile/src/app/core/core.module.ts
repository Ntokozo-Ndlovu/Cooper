import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { PostCardComponent } from './components/post-card/post-card.component';
import { IonicModule } from '@ionic/angular';
import {CommonModule} from "@angular/common";


@NgModule({
  declarations: [PostCardComponent],
  schemas:[CUSTOM_ELEMENTS_SCHEMA],
  imports: [
    IonicModule,
    CommonModule
  ],
  exports:[PostCardComponent]
})
export class CoreModule { }
