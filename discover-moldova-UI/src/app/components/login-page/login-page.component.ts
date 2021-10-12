import { Output, EventEmitter, Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginResponseViewModel } from 'src/app/models/login-user-response.model';
import { AuthService } from 'src/app/services/auth-service.service';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.css']
})
export class LoginPageComponent implements OnInit {

  constructor(private authService: AuthService,
              private router: Router) { }

  ngOnInit(): void {
  }

  hide = true;
  loginError = '';

  loginForm: FormGroup = new FormGroup({
    'username' : new FormControl(null, [Validators.required]),
    'password' : new FormControl(null, [Validators.required])
  });

  onSubmit() {
    if (this.loginForm.valid) {
      this.authService.loginUser(this.loginForm.value)
      .subscribe(
        (response:LoginResponseViewModel) => {
          localStorage.setItem('token', response.token);
          localStorage.setItem('user', JSON.stringify(response.user));
          this.router.navigate(['/home']);
        },
        (error) => { this.loginError = error.error; }
      )
    }
  }

  getUsernameErrorMessage(){

    if (this.loginForm.controls['username'].hasError('required')) {
      return 'You must enter a value';
    }

    return '';
  }

  getPasswordErrorMessage(){

    if (this.loginForm.controls['password'].hasError('required')) {
      return 'You must enter a value';
    }

    return '';
  }
}
