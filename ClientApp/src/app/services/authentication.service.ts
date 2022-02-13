import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { UtilityService } from './utitlity.service';

@Injectable({
  providedIn: 'root'
})
export class AuthenticationService {

  constructor(private http: HttpClient, private utilityService: UtilityService) { }

  register(body: RegisterModel) {
    return this.http.post('', body).pipe();
  }

  login(body: LoginModel) {
    return this.http.post('', body).pipe();
  }
}

export class RegisterModel {
  constructor() {
    this.fullName = '';
    this.email = '';
    this.password = '';
    this.cPassword = '';
  }
  fullName: string
  email: string
  password: string
  cPassword: string
}

export class LoginModel {
  constructor() {
    this.email = '';
    this.password = '';
  }
  email: string
  password: string
}
