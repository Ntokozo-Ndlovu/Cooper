import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomePageComponent } from './home-page/home-page.component';
import { HomePageRoutingModule } from './home-page-routing.module';
import { IonicModule } from '@ionic/angular';
import { CoreModule } from '../../core/core.module';
import { PostModule } from '../post/post.module';



@NgModule({
  declarations: [HomePageComponent],
  imports: [
    IonicModule,
    CoreModule,
    HomePageRoutingModule,
    CommonModule,
    PostModule
  ],
  exports:[HomePageComponent]
})
export class HomePageModule { }
