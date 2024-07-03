import { SignUpPersonPageComponent } from './sign-up-person-page/sign-up-person-page.component';
import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { SignUpAddressPageComponent } from './sign-up-address-page/sign-up-address-page.component';
import { SignUpContactPageComponent } from './sign-up-contact-page/sign-up-contact-page.component';
import { SignUpPageComponent } from './sign-up-page/sign-up-page.component';
import { SignUpRoutingModule } from './sign-up-routing.module';
import { IonicModule } from '@ionic/angular';
import { ReactiveFormsModule } from '@angular/forms';


@NgModule({
  declarations: [SignUpAddressPageComponent,SignUpPersonPageComponent,SignUpContactPageComponent,SignUpPageComponent],
  imports: [
    SignUpRoutingModule,
    CommonModule,
    ReactiveFormsModule,
    IonicModule
  ]
})
export class SignUpModule { }
