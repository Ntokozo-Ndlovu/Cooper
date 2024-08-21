import { ResponseBase } from "../../common"

export interface LikePostResponse extends ResponseBase{
  like: {
    userId: string,
    username: string,
    postId: string,
    likes: number
  }
}
