import { ResponseBase } from "../../common"

export interface FetchPostResponse  extends ResponseBase{
  post: {
    title: string,
    description: string,
    postId: number,
    challengeId: string,
    media: {
      type: number,
      url: string
    }[]
  }
}

