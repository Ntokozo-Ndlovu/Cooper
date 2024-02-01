import { Component, OnInit } from '@angular/core';
import { SignUpAddressPageComponent } from '../sign-up-address-page/sign-up-address-page.component';
import { FormBuilder, FormGroup } from '@angular/forms';
import * as fromAuth from 'src/app/core/ngrx/auth';
import { Contact } from 'src/app/core/interface/http/auth/sign-up.interface';
import { debounceTime } from 'rxjs';
import { Store } from '@ngrx/store';

@Component({
  selector: 'app-sign-up-contact-page',
  templateUrl: './sign-up-contact-page.component.html',
  styleUrls: ['./sign-up-contact-page.component.scss'],
})
export class SignUpContactPageComponent  implements OnInit {
  nextComponent = SignUpAddressPageComponent
  contactForm:FormGroup;
  constructor(formBuilder:FormBuilder,private store:Store) {
    this.contactForm = formBuilder.group({
      email:[''],
      phonenumber:['']
    })
   }

  ngOnInit() {
    this.contactForm.valueChanges.pipe(debounceTime(500)).subscribe((values)=>{
      const contacts:Contact = { email:values.email, phoneNumber:values.phonenumber};
      this.store.dispatch(fromAuth.fromActions.completeContactForm({contacts}));
    })
  }

}
