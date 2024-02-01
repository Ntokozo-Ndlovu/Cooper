import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Store } from '@ngrx/store';
import { Address } from 'src/app/core/interface/http/auth/sign-up.interface';
import * as fromAuth from 'src/app/core/ngrx/auth';

@Component({
  selector: 'app-sign-up-address-page',
  templateUrl: './sign-up-address-page.component.html',
  styleUrls: ['./sign-up-address-page.component.scss'],
})
export class SignUpAddressPageComponent  implements OnInit {

  addressForm:FormGroup;
  constructor(formBuilder:FormBuilder, private store:Store) {
    this.addressForm = formBuilder.group({
      streetName:[''],
      suburb:[''],
      city:[''],
      postalCode:['']
    })
   }

  ngOnInit() {
    this.addressForm.valueChanges.pipe().subscribe((form)=>{
      const address:Address = {
        streetName:form.streetName,
        suburb:form.suburb,
        city:form.city,
        postalCode:form.postalCode
      };
      this.store.dispatch(fromAuth.fromActions.completeAddressForm({address}))
    })
  }

}
