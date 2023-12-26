import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouteReuseStrategy } from '@angular/router';

import { IonicModule, IonicRouteStrategy } from '@ionic/angular';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { StoreModule } from '@ngrx/store';
import { ChallengeReducer, PostReducer } from './core/store/reducers';
@NgModule({
  declarations: [AppComponent],
  imports: [BrowserModule,HttpClientModule,IonicModule.forRoot() ,AppRoutingModule, StoreModule.forRoot({Challenge:ChallengeReducer, Post:PostReducer}, {})],
  providers: [{ provide: RouteReuseStrategy, useClass: IonicRouteStrategy }],
  bootstrap: [AppComponent],
})
export class AppModule {}
