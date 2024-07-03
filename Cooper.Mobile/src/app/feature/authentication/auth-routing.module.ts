import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';

const routes:Routes = [
  {
    path:'login',
    loadChildren:()=> import('./login/login.module').then(m=> m.LoginModule)
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
