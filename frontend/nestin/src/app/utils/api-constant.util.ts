export class ApiConstant {
  public static baseUrl = 'https://localhost:7026/api/v1';

  public static AccountsApi = {
    register: `${ApiConstant.baseUrl}/accounts/register`,
    login: `${ApiConstant.baseUrl}/accounts/login`,
    logout: `${ApiConstant.baseUrl}/accounts/logout`,
    'change-password': `${ApiConstant.baseUrl}/accounts/change-password`,
  };

  public static PropertiesApi = {
    getAll: `${ApiConstant.baseUrl}/Properties`,
    getById: `${ApiConstant.baseUrl}/Properties/{id}`,
    smartSearch: `${ApiConstant.baseUrl}/Properties/search`,
    getAllPropertyTypes: `${ApiConstant.baseUrl}/PropertyTypes`,
    getPropertyAmenities: `${ApiConstant.baseUrl}/Properties/{id}/Amenities`,
    getPropertyAvailability: `${ApiConstant.baseUrl}/Properties/{id}/Availabilities`,
    getPropertyFees: `${ApiConstant.baseUrl}/Properties/{id}/Fees`,
  };
  public static AmenitiesApi = {
    getAllAmenities: `${ApiConstant.baseUrl}/Amenities`,
    getAllAmenitiesCategories: `${ApiConstant.baseUrl}/AmenityCategories`,
  };

  public static FavoritePropertiesApi = {
    getAll: `${ApiConstant.baseUrl}/FavoriteProperties`,
    delete: `${ApiConstant.baseUrl}/FavoriteProperties`,
  };
  public static booking = {
    getAllBookings: `${ApiConstant.baseUrl}/Bookings`,
    createBooking: `${ApiConstant.baseUrl}/Bookings`,
  };
  public static country = {
    getAllCountries: `${ApiConstant.baseUrl}/Countries`,
  };
  public static region = {
    getAllRegions: `${ApiConstant.baseUrl}/Regions`,
  };
  public static location = {
    getAllLocations: `${ApiConstant.baseUrl}/Locations`,
  };

  public static Booking = {
    createBooking: `${ApiConstant.baseUrl}/Bookings`,
  };
  // Add other grouped APIs here
}
