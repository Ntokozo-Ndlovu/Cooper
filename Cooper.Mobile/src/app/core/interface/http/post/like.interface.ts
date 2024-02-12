export interface LikeRequest{
  userId: string,
  postId: string
}


export interface LikeResponse{
  postId:string,
  userId: string,
  username: string
}
