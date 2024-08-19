type Post = {
  media:   {
    type: number,
    url: string
  } [],
  title: string,
  description: string,
  like?:number,
  comments?:  {
    body: string
  }[],
  challengeId:string,
  postId: string
  }
export {Post};
