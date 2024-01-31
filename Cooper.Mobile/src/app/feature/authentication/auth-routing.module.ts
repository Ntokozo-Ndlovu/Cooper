import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LoginPageComponent } from './login/login-page/login-page.component';

const routes:Routes = [
  {
    path:'login',
    component:LoginPageComponent
  },
  {
    path:'signup',
    loadChildren: ()=> import('./sign-up/sign-up.module').then(m => m.SignUpModule)
    }
    ,
  {
    path:'',
    redirectTo:'login',
    pathMatch:'full'
  }
]
@NgModule({
  declarations: [],
  imports: [RouterModule.forChild(routes)],
  exports:[RouterModule]
})
export class AuthRoutingModule { }
