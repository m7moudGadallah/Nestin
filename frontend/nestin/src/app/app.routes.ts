import { Routes } from '@angular/router';
import { PropertyInfoComponent } from '../Component/property-info/property-info.component';

export const routes: Routes = [
    {
        path: 'propertyInfo/:id',
        component: PropertyInfoComponent
    }
];
