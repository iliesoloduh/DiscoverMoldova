import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { AuthService } from 'src/app/services/auth-service.service';
import { Router } from '@angular/router';


@Component({
  selector: 'app-register-page',
  templateUrl: './register-page.component.html',
  styleUrls: ['./register-page.component.css']
})
export class RegisterPageComponent implements OnInit {

  constructor(private authService: AuthService,
              private router: Router) { }

  ngOnInit(): void {
  }

  hidePassword = true;
  validationError = "";

  registerForm: FormGroup = new FormGroup({
    'firstname' : new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(50)]),
    'lastname' : new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(50)]),
    'email' : new FormControl(null, [Validators.required, Validators.email, Validators.maxLength(100)]),
    'username' : new FormControl(null, [Validators.required, Validators.minLength(3), Validators.maxLength(50)]),
    'password' : new FormControl(null, [Validators.required, Validators.minLength(8)])
  });

  onSubmit() {
    if (this.registerForm.valid) {
      this.authService.registerUser(this.registerForm.value)
      .subscribe(
        () => { this.router.navigate(['/login'])},
        (error) => {this.validationError = error.error;}
      );
    }
  }

  getFirstNameErrorMessage(){

    if (this.registerForm.controls['firstname'].hasError('required')) {
      return 'You must enter a value';
    }

    if (this.registerForm.controls['firstname'].hasError('minlength')) {
      return 'Minimum 3 characters long';
    }

    if (this.registerForm.controls['firstname'].hasError('maxlength')) {
      return 'Maximum 50 characters long';
    }

    return '';
  }

  getLastNameErrorMessage(){

    if (this.registerForm.controls['lastname'].hasError('required')) {
      return 'You must enter a value';
    }

    if (this.registerForm.controls['lastname'].hasError('minlength')) {
      return 'Minimum 3 characters long';
    }

    if (this.registerForm.controls['lastname'].hasError('maxlength')) {
      return 'Maximum 50 characters long';
    }

    return '';
  }

  getEmailErrorMessage(){

    if (this.registerForm.controls['email'].hasError('required')) {
      return 'You must enter a value';
    }

    if (this.registerForm.controls['email'].hasError('email')) {
      return 'Enter a valid email';
    }

    if (this.registerForm.controls['email'].hasError('maxlength')) {
      return 'Maximum 100 characters long';
    }

    return '';
  }

  getUsernameErrorMessage(){

    if (this.registerForm.controls['username'].hasError('required')) {
      return 'You must enter a value';
    }

    if (this.registerForm.controls['username'].hasError('minlength')) {
      return 'Minimum 3 characters long';
    }

    if (this.registerForm.controls['username'].hasError('maxlength')) {
      return 'Maximum 50 characters long';
    }

    return '';
  }

  getPasswordErrorMessage(){

    if (this.registerForm.controls['password'].hasError('required')) {
      return 'You must enter a value';
    }

    if (this.registerForm.controls['password'].hasError('minlength')) {
      return 'Minimum 8 characters long';
    }

    return '';
  }

}
