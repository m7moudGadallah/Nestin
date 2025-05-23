export class ApiConstant {
  private static domainUrl = 'https:localhost:7026';
  public static baseUrl = `${ApiConstant.domainUrl}/api/v1`;

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
    add: `${ApiConstant.baseUrl}/FavoriteProperties`,
  };
  public static booking = {
    getAllBookings: `${ApiConstant.baseUrl}/Bookings`,
    getBookingById: `${ApiConstant.baseUrl}/Bookings/{id}`,
    createBooking: `${ApiConstant.baseUrl}/Bookings`,
    cancelBooking: `${ApiConstant.baseUrl}/Bookings/{id}/cancel`,
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
    checkout: `${ApiConstant.baseUrl}/Bookings/{bookingId}/checkout`,
  };

  public static upgrade = {
    upgrade: `${ApiConstant.baseUrl}/HostUpgradeRequests`,
  };
  public static UserProfile = {
    Users: `${ApiConstant.baseUrl}/UserProfiles`,
    User: `${ApiConstant.baseUrl}/UserProfiles/me`,
  };
  public static GuestType = {
    GuestType: `${ApiConstant.baseUrl}/GuestTypes`,
  };
  public static user = {
    getAllUsers: `${ApiConstant.baseUrl}/UserProfiles`,
  };

  public static propertyAmenity = {
    addAmenity: `${ApiConstant.baseUrl}/PropertyAmenities`,
  };

  public static propertyAvailability = {
    addAvailability: `${ApiConstant.baseUrl}/PropertyAvailabilities`,
  };

  public static propertyGuest = {
    addGuest: `${ApiConstant.baseUrl}/PropertyGuests`,
  };

  public static propertyPhoto = {
    addPhoto: `${ApiConstant.baseUrl}/PropertyPhotos`,
  };

  public static photoReorder = {
    reorder: `${ApiConstant.propertyPhoto.addPhoto}/reorder`,
  };

  public static propertySpaces = {
    addSpaces: `${ApiConstant.baseUrl}/PropertySpaces`,
    spaces: `${ApiConstant.baseUrl}/PropertySpaceTypes`,
  };

  public static propertySpacesItems = {
    addSpacesItem: `${ApiConstant.baseUrl}/propertySpaceItems`,
    spaceItems: `${ApiConstant.baseUrl}/PropertySpaceItemTypes`,
  };

  // Add other grouped APIs here
}
