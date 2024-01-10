import {Component, CUSTOM_ELEMENTS_SCHEMA, OnInit} from '@angular/core';
import { Post } from 'src/app/core/models';
import { HttpClient } from '@angular/common/http';
import { Observable, map } from 'rxjs';

@Component({
  selector: 'app-home-page',
  templateUrl: './home-page.component.html',
  styleUrls: ['./home-page.component.scss']
})
export class HomePageComponent  implements OnInit {
  post:Observable<Post[]>;
  constructor(private http:HttpClient) {
    this.post = this.http.get<any>('assets/dummy-data.json').pipe(map(response => {
      console.log('response: ', response)
      return  response.data}
      ))
   }

  ngOnInit() {}

}
