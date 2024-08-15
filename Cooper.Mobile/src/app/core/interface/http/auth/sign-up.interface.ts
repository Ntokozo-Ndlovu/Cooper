import { HttpStatusCode } from '@angular/common/http';
import { ResponseBase } from '../common';

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
    age: number,
    gender: string
  },
  password: {
    password: string
  }
}

export interface SignUpResponse extends ResponseBase {
  userId:string
}
