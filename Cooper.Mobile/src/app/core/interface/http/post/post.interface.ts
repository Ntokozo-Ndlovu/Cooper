export interface PostResponse {
  media:{
    type: 0,
    url: string
  } [],
  title: string,
  description: string,
  like: Like[],
  comments:   {
    body: string
  }[],
  challengeId:string,
  postId: string
}

export interface Like{
  postId: string,
  userId: string,
  username: string
}
