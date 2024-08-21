import { ResponseBase } from "../../common"

export interface FetchLikesForPostResponse extends ResponseBase{
  likes: {
    userId: string,
    username: string,
    postId: string,
    likes: number
  }
}
