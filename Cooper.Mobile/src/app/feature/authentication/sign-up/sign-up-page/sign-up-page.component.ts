import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SignUpPersonPageComponent } from '../sign-up-person-page/sign-up-person-page.component';
import * as fromAuth from 'src/app/core/ngrx/auth';
import { Store } from '@ngrx/store';


@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up-page.component.html',
  styleUrls: ['./sign-up-page.component.scss'],
})
export class SignUpPageComponent  implements OnInit {

  rootComponent = SignUpPersonPageComponent;
  constructor(private router:Router, private store:Store) { }

  ngOnInit() {
    this.store.select(fromAuth.fromSelectors.registerFormSelector).subscribe(value=>{
      console.log('Value changes: ', value);
    })
  }

}
