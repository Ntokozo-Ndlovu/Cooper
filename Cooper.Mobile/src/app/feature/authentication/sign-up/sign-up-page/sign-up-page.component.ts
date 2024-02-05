import { Component, EventEmitter, OnDestroy, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import * as fromAuth from 'src/app/core/ngrx/auth';
import { Store } from '@ngrx/store';
import { Observable, map, takeUntil, tap, BehaviorSubject, filter, combineLatestWith } from 'rxjs';
import { Address } from 'src/app/core/interface/http/auth/sign-up.interface';


@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up-page.component.html',
  styleUrls: ['./sign-up-page.component.scss'],
})
export class SignUpPageComponent  implements OnInit,OnDestroy {

  public activeRoute:BehaviorSubject<number> = new BehaviorSubject<number>(0);
  private destroy$:EventEmitter<unknown> = new EventEmitter();
  public pageValid:Observable<boolean>;
  routes:string[] =[]

  constructor(private router:Router, private store:Store) {
    this.store.select(fromAuth.fromSelectors.signUpPagesUrls).pipe(tap((routes)=>{
      this.routes = routes;
    }),
    takeUntil(this.destroy$)).subscribe();

    const routerEvent$ =  this.router.events
      .pipe(
        filter((event:any) => event.routerEvent instanceof NavigationEnd),
        map(event => event.routerEvent),
        takeUntil(this.destroy$));


    this.pageValid = this.store.select(fromAuth.fromSelectors.signUpPagesValid)
    .pipe(
      combineLatestWith(routerEvent$),
      map(([pageValid,routerEvent])=>{
        const currentPage = pageValid.find(page => page.url == routerEvent.url);
        if(currentPage)
          return currentPage.valid;
        return false;
      }),
      takeUntil(this.destroy$));
  }

  ngOnInit() {
    this.formValid().pipe(
      takeUntil(this.destroy$)).subscribe();
    this.router.navigateByUrl(this.routes[0]);
  }

  handleNextPage(){
    this.activeRoute.next(this.activeRoute.getValue() + 1);
    this.router.navigateByUrl(this.routes[this.activeRoute.getValue()]);
  }

  handlePreviousPage(){
    this.activeRoute.next(this.activeRoute.getValue() - 1);
    this.router.navigateByUrl(this.routes[this.activeRoute.getValue()]);
  }

  formValid():Observable<boolean>{
    return this.store.select(fromAuth.fromSelectors.signUpPagesValid).pipe(
      map((pages)=>{
        let valid = true;
        pages.forEach(page=>
          {
            valid = page.valid && valid;
          })

        return valid;
      })
    );
  }

  addressFormValidation(address:Address| undefined):boolean{
    if(address)
    if(address.postalCode && address.postalCode !=''){
      return true;
    }
    return false;
  }

  ngOnDestroy(): void {
    this.destroy$.emit();
  }

}
