import { Like } from '../../interface/http/post/post.interface';

type Post = {
  media:   {
    type: 0,
    url: string
  } [],
  title: string,
  description: string,
  like: Like[],
  comments:  {
    body: string
  }[],
  challengeId:string,
  postId: string
  }
export {Post};
