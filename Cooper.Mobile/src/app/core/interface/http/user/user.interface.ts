import { ResponseBase } from "../common"

export interface GetUserResponse extends ResponseBase{
  user: {
    username: string,
    address: {
      streetName: string,
      suburb: string,
      city: string,
      postalCode: string
    },
    contact: {
      email: string,
      phoneNumber: string
    },
    person: {
      name: string,
      surname: string,
      age: number,
      gender: string
    }
  }
}
