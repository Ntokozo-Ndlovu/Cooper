
type Post = {
  media:   {
    type: 0,
    url: string
  } [],
  title: string,
  description: string,
  like?:number,
  comments:  {
    body: string
  }[],
  challengeId:string,
  postId: string
  }
export {Post};
