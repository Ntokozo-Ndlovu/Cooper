import { Address, Contact, Person } from "../../interface/http/auth/sign-up.interface";


export interface User{
  username:string,
  address:Address,
  contact:Contact,
  person:Person
}
