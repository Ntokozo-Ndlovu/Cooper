import { Component, EventEmitter, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import * as fromAuth from 'src/app/core/ngrx/auth';
import { Contact } from 'src/app/core/interface/http/auth/sign-up.interface';
import { debounceTime, distinctUntilChanged, takeUntil } from 'rxjs';
import { Store } from '@ngrx/store';

@Component({
  selector: 'app-sign-up-contact-page',
  templateUrl: './sign-up-contact-page.component.html',
  styleUrls: ['./sign-up-contact-page.component.scss'],
})
export class SignUpContactPageComponent  implements OnInit, OnDestroy {
  contactForm:FormGroup;
  destroy$:EventEmitter<unknown> = new EventEmitter();

  constructor(formBuilder:FormBuilder,private store:Store) {
    this.contactForm = formBuilder.group({
      email:[''],
      phonenumber:['']
    })
   }

  ngOnInit() {
    this.contactForm.valueChanges.pipe(debounceTime(500),takeUntil(this.destroy$)).subscribe((values)=>{
      const contacts:Contact = { email:values.email, phoneNumber:values.phonenumber};
      this.store.dispatch(fromAuth.fromActions.completeContactForm({contacts}));
    })

    this.store.select(fromAuth.fromSelectors.contactFormSelector)
      .pipe(distinctUntilChanged((a,b)=>JSON.stringify(a) == JSON.stringify(b)),takeUntil(this.destroy$))
      .subscribe((contactForm)=>{
        this.contactForm.setValue({
          email:contactForm?.email,
          phonenumber:contactForm?.phoneNumber
        })
      })
  }

  ngOnDestroy(): void {
      this.destroy$.emit();
  }

}
