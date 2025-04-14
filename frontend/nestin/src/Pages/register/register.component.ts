import { Component, OnInit } from '@angular/core';
import { FormBuilder, FormGroup, FormsModule, ReactiveFormsModule,Validators } from '@angular/forms';

import { RouterModule } from '@angular/router';
//import { CountryNamesService } from '../../Services/country-names.service';
import { CommonModule } from '@angular/common';
//import { AuthService } from '../../Services/services/auth.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-register',
  standalone: true,
  imports: [RouterModule,CommonModule, FormsModule,ReactiveFormsModule,RouterModule],
  templateUrl: './register.component.html',
  styleUrl: './register.component.css'
})
export class RegisterComponent implements OnInit {
  countries: string[] = [];
  signupForm: FormGroup;
constructor(private countryName:CountryNamesService,private fb:FormBuilder ,private authService:AuthService,private router:Router) {
  this.signupForm = this.fb.group({
    firstName: ['', [Validators.required, Validators.minLength(2)]],
    lastName: ['', [Validators.required, Validators.minLength(2)]],
    phone: ['', [Validators.required, Validators.pattern(/^\d{8,11}$/)]],
    country: ['', Validators.required],
    birthday: ['', [Validators.required, this.minimumAgeValidator(18)]],
    email: ['', [Validators.required, Validators.email]],
    password: ['', [
      Validators.required,
      Validators.minLength(12),
      Validators.pattern(/^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+])[A-Za-z\d!@#$%^&*()_+]{12,}$/)
    ]]
  });

}
ngOnInit(): void {
  this.countries = this.countryName.getCountries();
}
get f() { return this.signupForm.controls; }

onSubmit(): void {
  if (this.signupForm.valid) {
    const formData = this.signupForm.value;

    this.authService.register(formData).subscribe({
      next: (res) => {
        this.router.navigate(['/home']);
        
      },
      error: (err) => {
        console.error('Registration error:', err);
      }
    });

  } else {
    this.signupForm.markAllAsTouched();
  }
}
minimumAgeValidator(minAge: number) {
  return (control: any) => {
    const birthDate = new Date(control.value);
    const today = new Date();

    if (isNaN(birthDate.getTime())) {
      return null; // Ignore if not a valid date yet
    }

    const age = today.getFullYear() - birthDate.getFullYear();
    const monthDiff = today.getMonth() - birthDate.getMonth();
    const dayDiff = today.getDate() - birthDate.getDate();

    const isOldEnough =
      age > minAge ||
      (age === minAge && (monthDiff > 0 || (monthDiff === 0 && dayDiff >= 0)));

    return isOldEnough ? null : { tooYoung: true };
  };
}
}
