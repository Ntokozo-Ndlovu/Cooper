import { ResponseBase } from "../../common";

export interface CreateCommentResponse  extends ResponseBase{
 comment: {
    id: number,
    title: string,
    body: string,
    parentId: number,
    comments:any[],
    postId: number
  }
}
