import { HttpStatusCode } from '@angular/common/http';

export interface SignUpRequest {
  userName: string,
  address: Address,
  contact: Contact,
  person: Person,
  password:Password
}

export interface Address{
  streetName: string,
  suburb: string,
  city: string,
  postalCode: string
}
export interface Contact {
  email: string,
  phoneNumber: string
}


export interface Password  {
  password: string
}

export interface Person{
  name: string,
  surname: string,
  age: 0,
  gender: string
}

export interface SignUpResponse {
  userID: string,
  message: string,
  statusCode: HttpStatusCode
}
