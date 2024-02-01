import { Password } from './../../../../core/interface/http/auth/sign-up.interface';
import { Component, OnInit } from '@angular/core';
import { SignUpContactPageComponent } from '../sign-up-contact-page/sign-up-contact-page.component';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Store } from '@ngrx/store';
import { debounceTime } from 'rxjs';
import { Person } from 'src/app/core/interface/http/auth/sign-up.interface';
//import { fromAuth } from 'src/app/core/ngrx/post';
import * as fromAuth from 'src/app/core/ngrx/auth'

@Component({
  selector: 'app-sign-up-person-page',
  templateUrl: './sign-up-person-page.component.html',
  styleUrls: ['./sign-up-person-page.component.scss'],
})
export class SignUpPersonPageComponent  implements OnInit {
  nextComponent = SignUpContactPageComponent;
  public form:FormGroup;

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
    this.form.valueChanges.pipe(debounceTime(500)).subscribe(values=>{
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
      console.log('Values: ',values)
    //  const personForm:Person = {person,password};
      this.store.dispatch(fromAuth.fromActions.completePersonForm({username,person,password}));
     })
  }

}
