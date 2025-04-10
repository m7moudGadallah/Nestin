import { ILocation } from "./ilocation";
import { IPropertyAmenity } from "./iproperty-amenity";
import { IReview } from "./ireview";
import { Iuser } from "./iuser";

export interface IPropertyInfo {
    id: number;
    name: string;
    description: string;
    pricePerNight: number;
    numBeds: number;
    numBedrooms: number;
    reviewCount: number;
    averageRating: number;
    propertyType: {
      name: string;
    };
    amenities: IPropertyAmenity[];
    reviews: IReview[];
    host: Iuser;
    location: ILocation;
}
