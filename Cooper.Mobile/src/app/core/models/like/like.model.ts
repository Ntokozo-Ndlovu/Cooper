export class Like{
  postId: string;
  userId: string;
  username: string;

  constructor(postId:string, userId:string, username:string){
    this.postId = postId;
    this.userId = userId;
    this.username = username;
  }
}
