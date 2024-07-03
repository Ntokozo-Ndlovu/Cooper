import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SignUpPageComponent } from './sign-up-page/sign-up-page.component';
import { SignUpPersonPageComponent } from './sign-up-person-page/sign-up-person-page.component';
import { SignUpAddressPageComponent } from './sign-up-address-page/sign-up-address-page.component';
import { SignUpContactPageComponent } from './sign-up-contact-page/sign-up-contact-page.component';

const routes:Routes = [{
  path:'',
  component:SignUpPageComponent,
  children:[
    {
      path:'sign-up-person',
      component:SignUpPersonPageComponent
    },
    {
      path:'sign-up-address',
      component:SignUpAddressPageComponent
    },
    {
      path:'sign-up-contact',
      component:SignUpContactPageComponent
    }

  ]
}


]
@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild(routes)
  ],
  exports:[RouterModule]
})
export class SignUpRoutingModule { }
