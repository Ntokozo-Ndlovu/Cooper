import { Injectable } from '@angular/core';
import { HttpGatewayService } from '../http';
import { Observable } from 'rxjs';
import { CreateCommentResponse, FetchCommentsResponse } from 'interface/http/comment/response';
import { CreateCommentRequest } from 'interface/http/comment/requests';
import { reqUserInformation } from 'src/app/core/ngrx/app/app.actions';

@Injectable({
  providedIn: 'root'
})
export class CommentsService {
  private rootURI:string = "comment"

  constructor(private httpGatewayService:HttpGatewayService) { }

  fetchComments(postId:number):Observable<FetchCommentsResponse>{

    return this.httpGatewayService.get<FetchCommentsResponse>(`${this.rootURI}/${postId}`);
  }

  createComment(title:string, body:string,postId:number ,parentId:number = 0):Observable<CreateCommentResponse>{
    let requestBody:CreateCommentRequest = {
      title,
      body,
      parentId,
      postId
    }
    return this.httpGatewayService.post<CreateCommentResponse>(`${this.rootURI}`,requestBody);
  }

}
