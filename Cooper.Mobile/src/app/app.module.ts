import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { RouteReuseStrategy } from '@angular/router';

import { IonicModule, IonicRouteStrategy } from '@ionic/angular';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { CommonModule } from '@angular/common';
import { NgrxModule } from './core/ngrx/ngrx.module';
import { ErrorsModule } from './feature/errors/errors.module';

@NgModule({
  declarations: [AppComponent],
  imports: [BrowserModule,CommonModule,HttpClientModule,IonicModule.forRoot(),AppRoutingModule, NgrxModule, ErrorsModule],
  providers: [{ provide: RouteReuseStrategy, useClass: IonicRouteStrategy }],
  bootstrap: [AppComponent],
})
export class AppModule {}
