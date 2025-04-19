import { Country } from "./countries";

export interface Region{
    id:number;
    name:string;
    countries: Country[];
}