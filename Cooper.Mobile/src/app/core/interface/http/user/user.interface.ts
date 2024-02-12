
export interface GetUserResponse {
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
    age: 0,
    gender: string
  }

}
