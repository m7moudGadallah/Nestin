export interface Property{
    id: string;
  title: string;
  pricePerNight: number;
  latitude: number;
  longitude: number;
  distanceFromMe?: string;
  cancellationPolicy:string;
  houseRules:string;
  owner: {
    id: string;
    userName: string;
  };
  location: Location;  //property location
  propertyType: {
    id: number;
    name: string;
    icon: string;
  };
  photos: Array<{ photoUrl: string }>;  //property image
  averageRating: number;
  reviewCount: number;
  imageUrl?: string;
}