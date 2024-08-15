import { Address } from "./address.model";
import { Contact } from "./contact.model";
import { Person } from "./person.model";

export interface User{
  username:string,
  address:Address,
  contact:Contact,
  person:Person
}
