import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs'; 
import { CreateUser } from '../models/user/create-user.model';
import { LoginResponseViewModel } from '../models/user/login-user-response.model';
import { LoginUserViewModel } from '../models/user/login-user.model';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(private httpService: HttpClient) { }

  registerUser(user: CreateUser): Observable<{}> {
    return this.httpService.post("https://localhost:44376/api/users", user);
  }

  loginUser(loginUser: LoginUserViewModel): Observable<LoginResponseViewModel>{
    return this.httpService.post<LoginResponseViewModel>("https://localhost:44376/api/users/login", loginUser);
  }
}
