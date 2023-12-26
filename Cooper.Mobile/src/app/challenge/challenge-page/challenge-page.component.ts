import { Component, OnInit } from '@angular/core';
import { Challenge } from 'src/app/core/models';

@Component({
  selector: 'app-challenge-page',
  templateUrl: './challenge-page.component.html',
  styleUrls: ['./challenge-page.component.scss'],
})
export class ChallengePageComponent  implements OnInit {
  challenges:Challenge[]=[
    {title:"Best Pictitr",price:"R 123",description:"Take a selfie at Zwane",id:"asdasdf",startDate:new Date(), endDate:new Date()},
    {title:"Best Pictitr",price:"R 123",description:"Take a selfie at Zwane",id:"asdasdf",startDate:new Date(), endDate:new Date()},
    {title:"Best Pictitr",price:"R 123",description:"Take a selfie at Zwane",id:"asdasdf",startDate:new Date(), endDate:new Date()},
    {title:"Best Pictitr",price:"R 123",description:"Take a selfie at Zwane",id:"asdasdf",startDate:new Date(), endDate:new Date()},
    {title:"Best Pictitr",price:"R 123",description:"Take a selfie at Zwane",id:"asdasdf",startDate:new Date(), endDate:new Date()},
    {title:"Best Pictitr",price:"R 123",description:"Take a selfie at Zwane",id:"asdasdf",startDate:new Date(), endDate:new Date()}
  ]
  constructor() { }

  ngOnInit() {}

}
