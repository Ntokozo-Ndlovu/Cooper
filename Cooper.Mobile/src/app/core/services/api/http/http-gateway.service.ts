import { Observable } from 'rxjs';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';


@Injectable({
  providedIn: 'root'
})
export class HttpGatewayService {
  private baseUrl: string = `${environment.api.URL}:${environment.api.PORT}/${environment.api.baseURL}`

  constructor(private http:HttpClient) { }

  get<T>(url:string,options ={}):Observable<T>{
    return this.http.get<T>(`${this.baseUrl}/${url}`,options);
  }

  post<T>(url:string,body:unknown,options = {}):Observable<T>{
    return this.http.post<T>(`${this.baseUrl}/${url}`,body,options);
  }

  delete<T>(url:string, headers:HttpHeaders = new HttpHeaders(),options ={}){
    return this.http.delete<T>(`${this.baseUrl}/${url}`,{headers:headers,...options})
  }
}
