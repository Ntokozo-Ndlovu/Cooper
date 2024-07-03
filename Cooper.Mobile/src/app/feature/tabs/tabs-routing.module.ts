import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { TabsPage } from './tabs.page';
import { AuthGuard } from 'src/app/core/guards/auth.guard';

const routes: Routes = [
  {
    path: 'tabs',
    component: TabsPage,
    children: [
      {
        path:'home',
        loadChildren:() => import('../home/home-page.module').then(m=> m.HomePageModule)
      },
      {path:'challenges',
      loadChildren: () => import('../challenge/challenge.module').then(m => m.ChallengeModule)
    },
    {
      path:'profile',
      loadChildren:()=> import('../profile/profile.module').then(m => m.ProfileModule)
    },
      {
        path: '',
        redirectTo: '/home',
        pathMatch: 'full'
      }
    ],
    canActivate:[AuthGuard]
  },
  {
    path: '',
    redirectTo: '/tabs/home',
    pathMatch: 'full'
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
})
export class TabsPageRoutingModule {}
