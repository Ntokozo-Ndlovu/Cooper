import { Injectable } from '@angular/core';
import { HttpGatewayService } from '../http';
import { LikeRequest, LikeResponse } from 'src/app/core/interface/http/post';
import { HttpHeaders } from '@angular/common/http';
import { FetchNumberOfLikesResponse, PostResponse } from 'src/app/core/interface/http/post/post.interface';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class PostService {

  constructor(private http:HttpGatewayService) { }

  public likePost(likeRequest:LikeRequest){
    return this.http.post<LikeResponse>('post/like', likeRequest)
  }

  public removeOnLikePost(likeRequest:LikeRequest){
    const httpHeaders = new HttpHeaders({...likeRequest});
    return this.http.delete<LikeResponse>('post/like',httpHeaders);
  }

  public getAllPosts(){
    return this.http.get<PostResponse[]>('post')
  }

  public getLikesForPost(postId:string):Observable<FetchNumberOfLikesResponse>{
    return this.http.get<FetchNumberOfLikesResponse>(`post/like/${postId}`);
  }

}
