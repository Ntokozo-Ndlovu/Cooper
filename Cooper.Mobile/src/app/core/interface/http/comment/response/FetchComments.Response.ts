import { ResponseBase } from "../../common";

export interface FetchCommentsResponse extends ResponseBase {
  comments: [
    {
      id: number,
      title: string,
      body: string,
      parentId: number,
      comments: {
        id: number,
        title: string,
        body: string,
        parentId: number,
        comments: [],
        postId: number
      }[],
      postId: number
    }
  ]
}
