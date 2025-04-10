export interface IProperty {
  //   id: string;
  // name: string;
  // description: string;
  // price_per_night: number;
  // location_id: number;
  // latitude: number;
  // longitude: number;
  // max_guests: number;
  // num_beds: number;
  // num_bedrooms: number;
  // num_bathrooms: number;
  // safety_info: string;
  // house_rules: string;
  // cancellation_policy: string;
  // host_id: string;
  // type_id: number;

  // id: number;
  // title: string;
  // description: string;
  // price_per_night: number;
  // host: {
  //   name: string;
  //   avatarUrl: string;
  //   joinedDate: string;
  // };
  // guests: number;
  // bedrooms: number;
  // beds: number;
  // baths: number;
  // amenities: string[];
  // rules: string[];
  // location: {
  //   address: string;
  //   lat: number;
  //   lng: number;
  // };
  // name: string;
  // description: string;
  // price_per_night: number;
  // location: string;
  // latitude: number;
  // longitude: number;
  // max_guests: number;
  // num_beds: number;
  // num_bedrooms: number;
  // num_bathrooms: number;
  // safety_info: string;
  // house_rules: string;
  // cancellation_policy: string;
  // type: string;

  id: string;
  name: string;
  description: string;
  pricePerNight: number;
  location: string;
  maxGuests: number;
  numBeds: number;
  numBedrooms: number;
  numBathrooms: number;
  safetyInfo: string;
  houseRules: string;
  cancellationPolicy: string;
  latitude: number;
  longitude: number;
  type: string;
  
}
