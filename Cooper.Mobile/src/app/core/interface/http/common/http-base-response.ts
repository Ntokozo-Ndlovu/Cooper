import { HttpStatusCode } from "@angular/common/http";

export interface ResponseBase{
    status:HttpStatusCode,
    description:string
}
