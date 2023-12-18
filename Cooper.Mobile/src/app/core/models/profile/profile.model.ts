import { Address } from "./address.model"
type Profile = {
    name:string,
    surname:string,
    profilePicture?:string,
    dateOfBirth:Date,
    address?:Address,
    bio:string
}

export {Profile}