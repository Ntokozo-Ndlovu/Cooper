import { ResponseBase } from "../../common"

export interface ChallengeListResponse extends ResponseBase{
  challenges: {
    name: string,
    description: string,
    challengeId: string,
    title: string,
    startDate: string,
    endDate: string,
    price: number
  }[]
}
