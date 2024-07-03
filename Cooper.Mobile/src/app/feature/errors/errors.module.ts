import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import {ErrorBannerComponent} from './error-banner/error-banner.component';
import { IonicModule } from '@ionic/angular';


@NgModule({
  declarations: [ErrorBannerComponent],
  imports: [
    CommonModule,
    IonicModule
  ],
  exports:[ErrorBannerComponent]
})
export class ErrorsModule { }
