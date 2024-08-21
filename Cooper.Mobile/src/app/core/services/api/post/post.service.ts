import { Injectable } from '@angular/core';
import { HttpGatewayService } from '../http';
import { HttpHeaders } from '@angular/common/http';
import { Observable } from 'rxjs';
import { DeleteLikePostResponse, DeletePostLikeRequest, FetchLikesForPostResponse, FetchPostListResponse, LikePostResponse, PostLikeRequest } from 'src/app/core/interface/http/post';

@Injectable({
  providedIn: 'root'
})
export class PostService {

  constructor(private http: HttpGatewayService) { }

  public likePost(likeRequest: PostLikeRequest) {
    return this.http.post<LikePostResponse>('post/like', likeRequest)
  }

  public removeOnLikePost(likeRequest: DeletePostLikeRequest) {
    const httpHeaders = new HttpHeaders({userId:parseInt( likeRequest.userId), postId: parseInt(likeRequest.postId)});
    return this.http.delete<DeleteLikePostResponse>('post/like',httpHeaders);
  }

  public getAllPosts(userId: string) {
    return this.http.get<FetchPostListResponse>(`post/list/${userId}`)

  }

  public getLikesForPost(postId: string): Observable<FetchLikesForPostResponse> {
    return this.http.get<FetchLikesForPostResponse>(`post/like/${postId}`);
  }

}
