import { Password } from './../../../../core/interface/http/auth/sign-up.interface';
import { Component, EventEmitter, OnDestroy, OnInit } from '@angular/core';
import { SignUpContactPageComponent } from '../sign-up-contact-page/sign-up-contact-page.component';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import { Store } from '@ngrx/store';
import { debounceTime, distinctUntilChanged, takeUntil } from 'rxjs/operators';
import { Person } from 'src/app/core/interface/http/auth/sign-up.interface';
//import { fromAuth } from 'src/app/core/ngrx/post';
import * as fromAuth from 'src/app/core/ngrx/auth';
import { Router } from '@angular/router';

@Component({
  selector: 'app-sign-up-person-page',
  templateUrl: './sign-up-person-page.component.html',
  styleUrls: ['./sign-up-person-page.component.scss'],
})
export class SignUpPersonPageComponent  implements OnInit,OnDestroy {
  nextComponent = SignUpContactPageComponent;
  public form:FormGroup;
  destroy$:EventEmitter<unknown> = new EventEmitter<unknown>();
  private pageUrl:string;

  constructor(formbuilder:FormBuilder,
    private store:Store,
    private router:Router) {
      this.form = formbuilder.group({
        username:['',[Validators.required]],
        name:['',Validators.required],
        surname:['',Validators.required],
        gender:[''],
        age:[12, Validators.min(12)],
        password:['',[Validators.minLength(4)]]
      })
      this.pageUrl = this.router.url;

    }

    get f(){
    return this.form.controls;
  }

  ngOnInit() {
    this.form.valueChanges.pipe(
      distinctUntilChanged((a,b)=> JSON.stringify(a) == JSON.stringify(b)),
      debounceTime(500),
      takeUntil(this.destroy$)).subscribe((values)=>{
      this.form.updateValueAndValidity()
      this.store.dispatch(fromAuth.fromActions.validateFormPage({url:this.pageUrl,valid:this.form.valid}))

      if(this.form.valid){
        const username:string = values.username;
        const person:Person = {
          name:values.name,
          surname: values.surname,
          age:values.age,
          gender:values.gender
        };

        const password:Password = {
          password: values.password
        };
        const form = {username,person,password};
        this.store.dispatch(fromAuth.fromActions.completePersonForm(form));
        }
      })

     //if

     this.store.select(fromAuth.fromSelectors.personFormSelector)
     .pipe(takeUntil(this.destroy$),
      distinctUntilChanged((a,b)=> JSON.stringify(a) == JSON.stringify(b))).subscribe((personForm)=>{
        this.form.setValue({
          username:personForm.userName,
          name:personForm.person?.name,
          surname:personForm.person?.surname,
          gender:personForm.person?.gender,
          age:personForm.person?.age,
          password:personForm.password?.password
        })
      })
    }


  ngOnDestroy(): void {
        this.destroy$.emit();
  }
}
