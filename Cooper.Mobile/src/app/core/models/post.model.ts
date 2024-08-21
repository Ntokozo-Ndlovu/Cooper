type Post = {
  media:   {
    type: number,
    url: string
  } [],
  title: string,
  description: string,
  like?:number,
  userLiked?:boolean,
  comments?:  {
    body: string
  }[],
  challengeId:string,
  postId: string
  }
export {Post};
