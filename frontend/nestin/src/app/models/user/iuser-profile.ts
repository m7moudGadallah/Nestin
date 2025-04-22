import { ICountry } from '../country/icountry';
import { IUserPhoto } from './iuser-photo';

export interface IUserProfile {
  userId: string;
  userName: string;
  email: string;
  firstName: string;
  lastName: string;
  phoneNumber: string;
  bio: string;
  birthDate: string;
  country: ICountry;
  photo: IUserPhoto;
}
