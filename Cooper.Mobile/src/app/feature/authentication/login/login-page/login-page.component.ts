import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.scss'],
})
export class LoginPageComponent  implements OnInit {

  constructor(private router:Router) { }

  ngOnInit() {}

  handleSignUp(){
    this.router.navigate(['auth','signup'])
  }

}
