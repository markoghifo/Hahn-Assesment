import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthenticationService, LoginModel } from 'src/app/services/authentication.service';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  loginForm: FormGroup;
  login: LoginModel = new LoginModel();
  loading: boolean = false;
  showPassword:boolean = false;
  isChecked:boolean = false;

  constructor(private authService: AuthenticationService) {
    this.loginForm = new FormGroup({
      'email': new FormControl(this.login.email, [Validators.required, Validators.email]),
      // 'phone': new FormControl(this.register.phone, [Validators.pattern('[+]{1}[2-4]{3}[0-9]{10}'), Validators.required]),
      'password': new FormControl(this.login.password, Validators.required),
    }); }

  ngOnInit(): void {
  }

  get email() { return this.loginForm.get('email'); }
  get password() { return this.loginForm.get('password'); }

  onSubmit() {
    this.loading = true;
    // console.log(this.registerForm.value);
    this.authService.login(this.loginForm.value).subscribe(
      data => {
        this.loading = false;
        this.loginForm.reset();
        // console.log(data);
        // Swal.fire({
        //   position: 'top-end',
        //   icon: data.error ? 'error' : 'success',
        //   title: data.message,
        //   text: data.error ? '' : 'Please check your mail to verify your account',
        //   showConfirmButton: true
        // }).then((res) => {
        //   const returnUrl = this.route.snapshot.queryParams['returnUrl'];
        //   // console.log(returnUrl);
        //   this.router.navigateByUrl(returnUrl);
        //   setTimeout(() => {
        //     window.location.reload();
        //   }, 1000);
        // });
      }, err => {
        this.loading = false;
        console.error(err);
        // Swal.fire({
        //   position: 'top-end',
        //   icon: 'error',
        //   title: err.message,
        //   text: err.errors.join(","),
        //   showConfirmButton: true,
        // })
      }
    )
    // console.warn(this.registerForm.value);
  }

  checkIfDataIsValid(): boolean {
    return this.loginForm.valid;
  }

}
