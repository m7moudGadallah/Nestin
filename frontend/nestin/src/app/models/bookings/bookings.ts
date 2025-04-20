export interface BookingResponse{
    items: Booking[];
    metaData: {
      page: number;
      pageSize: number;
      total: number;
    };
}
export interface Booking {
    propertyId: number;
    id:string;
    userId:string;
    checkIn:string;
    checkOut:string;
    pricePerNight:number;
    totalFees:number;
    status:string;
    createdAt:string;
    updatedAt:string;
    bookingGuests: {
        bookingId: string;
        guestTypeId: number;
        guestCount: number;
      }[];
    property: {
        id: string;
        title: string;
        pricePerNight: number;
        latitude: number;
        longitude: number;
        owner: {
          id: string;
          userName: string;
    };
    location: {
        id: number;
        name: string;
        countryId: number;
    };
    propertyType: {
        id: number;
        name: string;
        icon: string;
      };
      photos: {
        id: string;
        photoUrl: string;
      }[];
      averageRating: number;
      reviewCount: number;
    };
}