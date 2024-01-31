import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { SignUpBioPageComponent } from '../sign-up-bio-page/sign-up-bio-page.component';

@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up-page.component.html',
  styleUrls: ['./sign-up-page.component.scss'],
})
export class SignUpPageComponent  implements OnInit {

 rootComponent = SignUpBioPageComponent;
  constructor(private router:Router) { }

  ngOnInit() {
  }

}
