import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { PostRoutingModule } from './post-routing.module';
import { IonicModule } from '@ionic/angular';
import { PostPageComponent } from './post-page/post-page.component';
import { PostItemComponent } from './post-item/post-item.component';
import { CoreModule } from 'src/app/core/core.module';



@NgModule({
  declarations: [PostPageComponent,PostItemComponent],
  imports: [
    CommonModule,
    CoreModule,
    IonicModule,
    PostRoutingModule
  ],
  exports:[PostPageComponent]
})
export class PostModule { }
