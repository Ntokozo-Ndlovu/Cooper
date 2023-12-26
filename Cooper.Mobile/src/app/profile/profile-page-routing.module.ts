import { NgModule } from '@angular/core';
import { RouterModule,Routes } from '@angular/router';
import { ProfilePageComponent } from './profile-page/profile-page.component';

const path:Routes = [
  {
    path:'',
    component:ProfilePageComponent
  }
]
@NgModule({
  declarations: [],
  imports: [
  RouterModule.forChild(path)
  ],
  exports:[
    RouterModule
  ]
})
export class ProfilePageRoutingModule { }
