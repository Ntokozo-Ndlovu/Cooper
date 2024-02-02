import { Component, EventEmitter, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup } from '@angular/forms';
import { Store } from '@ngrx/store';
import { debounceTime, distinctUntilChanged, takeUntil } from 'rxjs';
import { Address } from 'src/app/core/interface/http/auth/sign-up.interface';
import * as fromAuth from 'src/app/core/ngrx/auth';

@Component({
  selector: 'app-sign-up-address-page',
  templateUrl: './sign-up-address-page.component.html',
  styleUrls: ['./sign-up-address-page.component.scss'],
})
export class SignUpAddressPageComponent  implements OnInit,OnDestroy {

  addressForm:FormGroup;
  destroy$:EventEmitter<unknown> = new  EventEmitter();

  constructor(formBuilder:FormBuilder, private store:Store) {
    this.addressForm = formBuilder.group({
      streetName:[''],
      suburb:[''],
      city:[''],
      postalCode:['']
    })
   }

  ngOnInit() {
    this.addressForm.valueChanges.pipe(debounceTime(500),takeUntil(this.destroy$)).subscribe((form)=>{
      const address:Address = {
        streetName:form.streetName,
        suburb:form.suburb,
        city:form.city,
        postalCode:form.postalCode
      };
      this.store.dispatch(fromAuth.fromActions.completeAddressForm({address}))
    });

    this.store.select(fromAuth.fromSelectors.addressFormSelector).pipe(
      distinctUntilChanged((a,b)=> JSON.stringify(a) == JSON.stringify(b)),
      takeUntil(this.destroy$)
    ).subscribe((addressForm)=>{
      this.addressForm.setValue({
        streetName:addressForm?.streetName,
        suburb:addressForm?.suburb,
        city:addressForm?.city,
        postalCode:addressForm?.postalCode
      })
    })
  }

  ngOnDestroy(): void {
    this.destroy$.emit();
  }

}
