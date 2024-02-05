import { reducers } from './reducers/index';
import { NgModule } from "@angular/core";
import { EffectsModule } from "@ngrx/effects";
import { StoreModule } from "@ngrx/store";
import { ChallengeEffects } from './challenge/challenge.effects';
import { PostEffects } from './post/post.effects';
import { AuthEffects } from './auth/auth.effects';
import { AppEffects } from './app/app.effects';


@NgModule({
  imports:[
    StoreModule.forRoot(reducers),
    EffectsModule.forRoot([
      AppEffects,
      ChallengeEffects,
      PostEffects,
      AuthEffects
  ])
  ]
})
export class NgrxModule{
}
