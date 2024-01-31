import { Component, OnInit } from '@angular/core';
import { SignUpContactPageComponent } from '../sign-up-contact-page/sign-up-contact-page.component';
@Component({
  selector: 'app-sign-up-bio-page',
  templateUrl: './sign-up-bio-page.component.html',
  styleUrls: ['./sign-up-bio-page.component.scss'],
})
export class SignUpBioPageComponent  implements OnInit {
  nextComponent = SignUpContactPageComponent;
  constructor() { }

  ngOnInit() {}

}
