import { Component, EventEmitter, OnDestroy, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';
import { Store } from '@ngrx/store';
import { Observable, map, takeUntil, tap, BehaviorSubject, filter, combineLatestWith } from 'rxjs';
import { Address, Contact, Password, Person } from 'src/app/core/interface/http/auth/sign-up.interface';

import * as fromAuth from 'src/app/core/ngrx/auth';
import * as fromApp from 'src/app/core/ngrx/app';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up-page.component.html',
  styleUrls: ['./sign-up-page.component.scss'],
})
export class SignUpPageComponent  implements OnInit,OnDestroy {

  public activeRoute:BehaviorSubject<number> = new BehaviorSubject<number>(0);
  private destroy$:EventEmitter<unknown> = new EventEmitter();
  public pageValid:Observable<boolean>;
  public registeringLoading:Observable<boolean>;
  routes:string[] =[]

  constructor(private router:Router, private store:Store) {

    this.registeringLoading = this.store.select(fromAuth.fromSelectors.registeringLoadingSelector);

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

  handleRegister(){
    this.store.select(fromAuth.fromSelectors.registerFormSelector).pipe(
      takeUntil(this.destroy$)
    ).subscribe((registerForm)=>{

      const address:Address = registerForm.address as Address;
      const password = registerForm.password as Password;
      const person = registerForm.person as Person;
      const userName = registerForm.userName as string ;
      const contact = registerForm.contact as Contact;

      this.store.dispatch(fromAuth.fromActions.reqRegisterUser({userRequest:{address:address,password,person,userName,contact}}));
    });

    this.store.select(fromAuth.fromSelectors.userIdSelector)
    .pipe(
      takeUntil(this.destroy$),
      filter(userId=> userId !=''))
      .subscribe((userId)=>{
        this.store.dispatch(fromApp.fromActions.reqUserInformation({userId}))
        this.router.navigate(['tabs','home']);
      })

  }


  ngOnDestroy(): void {
    this.destroy$.emit();
  }

}
