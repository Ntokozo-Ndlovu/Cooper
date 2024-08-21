import { ResponseBase } from "../../common"

export interface FetchPostListResponse extends ResponseBase {
  posts: {
    title: string,
    description: string,
    postId: string,
    userLiked: boolean,
    challengeId: string,
    media: {
      type: number,
      url: string
    }[]
  }[]
}
