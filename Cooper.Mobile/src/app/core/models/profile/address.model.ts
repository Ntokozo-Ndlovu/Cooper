type Address = {
    street:string,
    suburb:string
    city:string,
    postalCode:string,
    gps:GPS
}

type GPS ={
    latitude:number,
    longitude:number
}

export {Address, GPS};