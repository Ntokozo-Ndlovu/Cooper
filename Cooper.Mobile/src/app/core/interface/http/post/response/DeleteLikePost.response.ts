import { ResponseBase } from "../../common"

export interface DeleteLikePostResponse extends ResponseBase {
  like: {
    userId: string,
    username: string,
    postId: string,
    likes: number

  }
}
