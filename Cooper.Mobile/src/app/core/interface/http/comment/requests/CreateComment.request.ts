export interface CreateCommentRequest {
  parentId: number,
  postId: number,
  title: string,
  body: string
}
