import {MediaType} from '../../enum/MediaType.enum';

type Post = {
    media:{
      type:MediaType,
      url:string
    }[],
    title:string,
    description:string
    like:number
    comments:string[]
  }
export {Post};