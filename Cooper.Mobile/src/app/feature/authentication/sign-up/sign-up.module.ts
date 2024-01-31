import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SignUpAddressPageComponent } from './sign-up-address-page/sign-up-address-page.component';
import { SignUpBioPageComponent } from './sign-up-bio-page/sign-up-bio-page.component';
import { SignUpContactPageComponent } from './sign-up-contact-page/sign-up-contact-page.component';
import { SignUpPageComponent } from './sign-up-page/sign-up-page.component';
import { SignUpRoutingModule } from './sign-up-routing.module';
import { IonicModule } from '@ionic/angular';



@NgModule({
  declarations: [SignUpAddressPageComponent,SignUpBioPageComponent,SignUpContactPageComponent,SignUpPageComponent],
  imports: [
    SignUpRoutingModule,
    CommonModule,
    IonicModule
  ]
})
export class SignUpModule { }
