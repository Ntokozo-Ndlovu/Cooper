import { HttpStatusCode } from '@angular/common/http';

export interface SignUpRequest {
  userName: string,
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
  },
  password: {
    password: string
  }
}


export interface SignUpResponse {
  userID: string,
  message: string,
  statusCode: HttpStatusCode
}
