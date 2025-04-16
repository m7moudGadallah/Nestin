export interface Property {
  id: string;
  name: string;
  description: string;
  pricePerNight: number;
  latitude: number;
  longitude: number;
  rating: number;
  imageUrl?: string;
  distanceFromMe?: string;
}
