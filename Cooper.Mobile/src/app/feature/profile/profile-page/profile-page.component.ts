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

  addressForm:FormGroup;
  contactForm:FormGroup;
  personForm:FormGroup;

  constructor(private store:Store, private formBuilder:FormBuilder) {
    this.addressForm = formBuilder.group({
      streetName:[''],
      suburb:[''],
      city:['',Validators.required],
      postalCode:['',Validators.required]
    })

    this.contactForm = formBuilder.group({
      email:['', [Validators.email,Validators.required]],
      phonenumber:['',[Validators.required]]
    })

    this.personForm = formBuilder.group({
      username:['',[Validators.required]],
      name:['',Validators.required],
      surname:['',Validators.required],
      gender:[''],
      age:[12, Validators.min(12)],
      password:['',[Validators.minLength(4)]]
    })
   }

  ngOnInit() {
    this.store.select(fromApp.fromSelectors.selectUser)
    .pipe(
      distinctUntilChanged((a,b)=> JSON.stringify(a) == JSON.stringify(b)),
      takeUntil(this.destroy$)
    ).subscribe((user)=>{

      console.log('Set the profile page user data')
      const address = user.address;
      const person = {...user.person, username:user.username}
      const contact = {...user.contact};
      if(address)
      this.addressForm.setValue(address);
      if(person)
      this.personForm.setValue(person);
      if(contact)
      this.personForm.setValue(contact)
    })

  }


  ngOnDestroy(){
    this.destroy$.emit();
  }
}
