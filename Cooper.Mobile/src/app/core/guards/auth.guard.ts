import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Store } from '@ngrx/store';
import { Observable, map } from 'rxjs';
import * as fromAuth from '../ngrx/auth';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {
  constructor(private router:Router, private store:Store){

  }
  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
      return this.store.select(fromAuth.fromSelectors.userIdSelector)
      .pipe(map((userId)=>{
        if(userId == '')
          this.router.navigate(['auth'])
        return true;
      }))
      //this.router.navigate(['auth']);
  }

}
