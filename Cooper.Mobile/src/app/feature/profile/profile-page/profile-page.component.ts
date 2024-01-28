import { Component, OnInit } from '@angular/core';
import { Profile } from 'src/app/core/models/profile/profile.model';

@Component({
  selector: 'app-profile-page',
  templateUrl: './profile-page.component.html',
  styleUrls: ['./profile-page.component.scss'],
})
export class ProfilePageComponent  implements OnInit {
  profile?:Profile = {
    name:"Ntokozo",
    surname:"Ndlovu",
    profilePicture:"",
    dateOfBirth:new Date(),
    bio:"I hate school so much what do I know, well well"
  }
  constructor() { }

  ngOnInit() {}

}
