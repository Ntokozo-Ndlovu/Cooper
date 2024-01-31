import { Component, OnInit } from '@angular/core';
import { SignUpAddressPageComponent } from '../sign-up-address-page/sign-up-address-page.component';
@Component({
  selector: 'app-sign-up-contact-page',
  templateUrl: './sign-up-contact-page.component.html',
  styleUrls: ['./sign-up-contact-page.component.scss'],
})
export class SignUpContactPageComponent  implements OnInit {
  nextComponent = SignUpAddressPageComponent
  constructor() { }

  ngOnInit() {}

}
