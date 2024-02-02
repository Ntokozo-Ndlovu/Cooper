import { Component, EventEmitter, OnDestroy, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import * as fromAuth from 'src/app/core/ngrx/auth';
import { Store } from '@ngrx/store';
import { Observable, map, takeUntil } from 'rxjs';


@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up-page.component.html',
  styleUrls: ['./sign-up-page.component.scss'],
})
export class SignUpPageComponent  implements OnInit,OnDestroy {

  public activeRoute:number = 0;
  private destroy$:EventEmitter<unknown> = new EventEmitter();

  constructor(private router:Router, private store:Store) { }
  routes:string[] =[
    'auth/signup/sign-up-person',
    'auth/signup/sign-up-address',
    'auth/signup/sign-up-contact',
  ]
  ngOnInit() {
    this.store.select(fromAuth.fromSelectors.registerFormSelector).pipe(
      takeUntil(this.destroy$)
    ).subscribe(value=>{
      console.log('Value changes: ', value);
    })
    this.router.navigateByUrl(this.routes[0]);
  }

  handleNextPage(){
    this.activeRoute++;
    this.router.navigateByUrl(this.routes[this.activeRoute]);
  }

  handlePreviousPage(){
    this.activeRoute--;
    this.router.navigateByUrl(this.routes[this.activeRoute]);
  }

  formValid():Observable<boolean>{
    return this.store.select(fromAuth.fromSelectors.registerFormSelector).pipe(
      takeUntil(this.destroy$),
      map(()=>{
       return false;
      })
    );
  }

  ngOnDestroy(): void {
    this.destroy$.emit();
  }

}
