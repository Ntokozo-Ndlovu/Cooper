import { ResponseBase } from "../common"

export interface LikeRequest{
  userId: string,
  postId: string
}


export interface LikeResponse extends ResponseBase{
  likes: {
    userId: string,
    username: string,
    postId: string,
    likes: number
  }
}
