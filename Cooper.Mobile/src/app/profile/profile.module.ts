import { NgModule } from '@angular/core';
import { ProfilePageComponent } from './profile-page/profile-page.component';
import { IonicModule } from '@ionic/angular';
import { ProfilePageRoutingModule } from './profile-page-routing.module';
import { CommonModule } from '@angular/common';
import { CoreModule } from '../core/core.module';



@NgModule({
  declarations: [ProfilePageComponent],
  imports: [
    IonicModule,
    ProfilePageRoutingModule,
    CoreModule
  ],
  exports:[ProfilePageComponent]
})
export class ProfileModule { }
