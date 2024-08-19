import { ResponseBase } from "../common"

export interface PostResponse  extends ResponseBase{
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

export interface PostListResponse extends ResponseBase {
  posts: {
    title: string,
    description: string,
    postId: string,
    challengeId: string,
    media: {
      type: number,
      url: string
    }[]
  }[]
}
