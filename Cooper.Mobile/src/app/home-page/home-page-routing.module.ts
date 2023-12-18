import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HomePageComponent } from './home-page/home-page.component';
import { Routes,RouterModule } from '@angular/router';
const path:Routes = [
  {path:"",
  component:HomePageComponent}
]

@NgModule({
  declarations: [],
  imports: [
    RouterModule.forChild(path)
  ],
  exports:[RouterModule]
})
export class HomePageRoutingModule { }
