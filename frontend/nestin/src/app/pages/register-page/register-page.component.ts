import { Component } from '@angular/core';
import {
  FormBuilder,
  FormGroup,
  FormsModule,
  ReactiveFormsModule,
  Validators,
} from '@angular/forms';
import { Router, RouterModule } from '@angular/router';
import { CommonModule } from '@angular/common';
import { AccountService } from '../../services/account.service';
import { IRegisterRes } from '../../models/api/response/iregister-res';

@Component({
  standalone: true,
  imports: [
    RouterModule,
    CommonModule,
    FormsModule,
    ReactiveFormsModule,
    RouterModule,
  ],
  templateUrl: './register-page.component.html',
  styleUrl: './register-page.component.scss',
})
export class RegisterPageComponent {
  countries: string[] = [];
  signupForm: FormGroup;
  constructor(
    private fb: FormBuilder,
    private accountService: AccountService,
    private router: Router
  ) {
    this.signupForm = this.fb.group({
      email: ['', [Validators.required, Validators.email]],
      password: [
        '',
        [
          Validators.required,
          Validators.minLength(12),
          Validators.pattern(
            /^(?=.*[A-Z])(?=.*\d)(?=.*[!@#$%^&*()_+])[A-Za-z\d!@#$%^&*()_+]{12,}$/
          ),
        ],
      ],
    });
  }

  get formControls() {
    return this.signupForm.controls;
  }

  onSubmit(): void {
    if (this.signupForm.valid) {
      const formData = this.signupForm.value;

      this.accountService
        .register({
          email: formData.email,
          password: formData.password,
        })
        .subscribe({
          next: (res: { body: IRegisterRes }) => {
            const body = res.body;
            if (body && body.token) {
              localStorage.setItem('accessToken', body.token);
              localStorage.setItem('userName', body.userName);
              localStorage.setItem('userId', body.id);
              this.router.navigate(['/home']);
            }
          },
          error: err => {
            console.error('Registration error:', err);
          },
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
        (age === minAge &&
          (monthDiff > 0 || (monthDiff === 0 && dayDiff >= 0)));

      return isOldEnough ? null : { tooYoung: true };
    };
  }
}
