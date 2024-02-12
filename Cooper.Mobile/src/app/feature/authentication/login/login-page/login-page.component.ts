import { Component, EventEmitter, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { Store } from '@ngrx/store';
import { filter, takeUntil } from 'rxjs';
import * as fromApp from 'src/app/core/ngrx/app';
import * as fromAuth from 'src/app/core/ngrx/auth';

@Component({
  selector: 'app-login',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.scss'],
})
export class LoginPageComponent  implements OnInit, OnDestroy {

  destroy$:EventEmitter<unknown> = new EventEmitter();
  loginForm:FormGroup;

  constructor(private router:Router,
    private store:Store,
    private formBuilder:FormBuilder) {
    this.loginForm = this.formBuilder.group({
      username:['',[Validators.required]],
      password:['',Validators.required]
    })

   }

  ngOnInit() {}

  handleSignUp(){
    this.router.navigate(['auth','signup'])
  }

  handleLogin(){
    console.log('Login In')
    this.store.dispatch(fromAuth.fromActions.reqLoginUser({loginRequest:this.loginForm.value} ));
    this.store.select(fromAuth.fromSelectors.userIdSelector)
    .pipe(
      filter(userId => userId != ''),
      takeUntil(this.destroy$))
      .subscribe((userId)=>{
        this.store.dispatch(fromApp.fromActions.reqUserInformation({userId}))
        this.router.navigate(['tabs','home'])
      })
  }

  ngOnDestroy(){
    this.destroy$.emit();
  }

}
