import { Password } from './../../../../core/interface/http/auth/sign-up.interface';
import { Component, EventEmitter, OnDestroy, OnInit } from '@angular/core';
import { SignUpContactPageComponent } from '../sign-up-contact-page/sign-up-contact-page.component';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Store } from '@ngrx/store';
import { debounceTime, distinctUntilChanged, takeUntil } from 'rxjs/operators';
import { Person } from 'src/app/core/interface/http/auth/sign-up.interface';
//import { fromAuth } from 'src/app/core/ngrx/post';
import * as fromAuth from 'src/app/core/ngrx/auth'

@Component({
  selector: 'app-sign-up-person-page',
  templateUrl: './sign-up-person-page.component.html',
  styleUrls: ['./sign-up-person-page.component.scss'],
})
export class SignUpPersonPageComponent  implements OnInit,OnDestroy {
  nextComponent = SignUpContactPageComponent;
  public form:FormGroup;
  destroy$:EventEmitter<unknown> = new EventEmitter<unknown>();

  constructor(formbuilder:FormBuilder,private store:Store) {
    this.form = formbuilder.group({
      username:[''],
      name:[''],
      surname:[''],
      gender:[],
      age:[12],
      password:['']
    })
  }

  validateForm(){

  }

  ngOnInit() {
    this.form.valueChanges.pipe(debounceTime(500),takeUntil(this.destroy$)).subscribe(values=>{
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
      this.store.dispatch(fromAuth.fromActions.completePersonForm({username,person,password}));
     })

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

    formValid(){
      return false;
    }
    ngOnDestroy(): void {
      this.destroy$.emit();
    }
}
