import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { AuthRoutingModule } from './auth-routing.module';
import { IonicModule } from '@ionic/angular';
import { LoginPageComponent } from './login/login-page/login-page.component';



@NgModule({
  declarations: [LoginPageComponent],
  imports: [
    AuthRoutingModule,
    CommonModule,
    IonicModule
  ]
})
export class AuthModule { }
