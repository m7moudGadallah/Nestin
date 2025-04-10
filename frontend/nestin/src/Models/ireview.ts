import { Iuser } from "./iuser";

export interface IReview {
    id :number;
    comment :string;
    cleanliness: number; 
    accuracy: number; 
    checkIn: number; 
    communication: number; 
    location: number; 
    value: number; 
    propertyId: string; 
    guestId: string; 
    createdAt: Date; 
    updatedAt: Date; 

    guest: Iuser;
}
