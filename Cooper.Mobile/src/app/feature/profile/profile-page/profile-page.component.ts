import { distinctUntilChanged, takeUntil } from 'rxjs';
import { Component, EventEmitter, OnDestroy, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, Validators } from '@angular/forms';
import * as fromApp from 'src/app/core/ngrx/app';
import { Store } from '@ngrx/store';


@Component({
  selector: 'app-profile-page',
  templateUrl: './profile-page.component.html',
  styleUrls: ['./profile-page.component.scss'],
})
export class ProfilePageComponent  implements OnInit, OnDestroy {

  private destroy$:EventEmitter<unknown> = new EventEmitter();

  addressForm:FormGroup = new FormGroup({});
  contactForm:FormGroup = new FormGroup({});
  personForm:FormGroup = new FormGroup({});

  constructor(private store:Store, private formBuilder:FormBuilder) {
   }

  ngOnInit() {
    this.store.select(fromApp.fromSelectors.selectUser)
    .pipe(
      distinctUntilChanged((a,b)=> JSON.stringify(a) == JSON.stringify(b)),
      takeUntil(this.destroy$)
    ).subscribe((user)=>{

      const address = user.address;
      const person = {...user.person, username:user.username}
      const contact = user.contact;

      if(address)
      this.addressForm = this.formBuilder.group({
        streetName:[address.streetName],
        suburb:[address.suburb],
        city:[address.city,Validators.required],
        postalCode:[address.postalCode,Validators.required]
      })

      if(person)
      this.personForm = this.formBuilder.group({
        username:[person.username,[Validators.required]],
        name:[person.name,Validators.required],
        surname:[person.surname,Validators.required],
        gender:[person.gender],
        age:[person.age, Validators.min(12)]
      })

      if(contact)
      this.contactForm = this.formBuilder.group({
        email:[contact.email, [Validators.email,Validators.required]],
        phonenumber:[contact.phoneNumber,[Validators.required]]
      })

    })

  }


  ngOnDestroy(){
    this.destroy$.emit();
  }
}
