import { ResponseBase } from "../../common"

export interface DeleteChallengeResponse extends ResponseBase {
  challenge: {
    name: string,
    description: string,
    challengeId:string,
    title: string,
    startDate: string,
    endDate:string,
    price: number
  }
}
