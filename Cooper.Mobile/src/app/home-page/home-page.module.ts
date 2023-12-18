import { CUSTOM_ELEMENTS_SCHEMA, NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PostCardComponent } from '../core/components/post-card/post-card.component';
import { HomePageComponent } from './home-page/home-page.component';
import { HomePageRoutingModule } from './home-page-routing.module';
import { IonicModule } from '@ionic/angular';
import { CoreModule } from '../core/core.module';



@NgModule({
  declarations: [HomePageComponent],
  imports: [
    IonicModule,
    CoreModule,
    HomePageRoutingModule,
    CommonModule
  ],
  exports:[HomePageComponent]
})
export class HomePageModule { }
