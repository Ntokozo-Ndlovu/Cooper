export interface Comment {
  id: number,
  title: string,
  body: string,
  parentId: number,
  comments: Comment[],
  postId: number
}

