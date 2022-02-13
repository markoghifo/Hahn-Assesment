import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { AuthenticationService, RegisterModel } from 'src/app/services/authentication.service';
import { UtilityService as UtilityService } from 'src/app/services/utitlity.service';

@Component({
  selector: 'app-register',
  templateUrl: './register.component.html',
  styleUrls: ['./register.component.scss']
})
export class RegisterComponent implements OnInit {

  registerForm: FormGroup;
  register: RegisterModel = new RegisterModel();
  loading: boolean = false;
  showPassword:boolean = false;
  isChecked:boolean = false;

  constructor(private authService: AuthenticationService, private utilityService: UtilityService) {
    this.registerForm = new FormGroup({
      'fName': new FormControl(this.register.fullName, [
        Validators.required,
        // Validators.minLength(4),
        // forbiddenNameValidator(/bob/i) // <-- Here's how you pass in the custom validator.
      ]),
      'email': new FormControl(this.register.email, [Validators.required, Validators.email]),
      // 'phone': new FormControl(this.register.phone, [Validators.pattern('[+]{1}[2-4]{3}[0-9]{10}'), Validators.required]),
      'password': new FormControl(this.register.password, Validators.required),
      'cPassword': new FormControl(this.register.cPassword, Validators.required),
    }); }

  ngOnInit(): void {
  }

  get fName() { return this.registerForm.get('fName'); }
  get email() { return this.registerForm.get('email'); }
  // get phone() { return this.registerForm.get('phone'); }
  get password() { return this.registerForm.get('password'); }
  get cPassword() { return this.registerForm.get('cPassword'); }

  onSubmit() {
    this.loading = true;
    // console.log(this.registerForm.value);
    this.authService.register(this.registerForm.value).subscribe(
      data => {
        this.loading = false;
        this.registerForm.reset();
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
    return this.registerForm.valid;
  }

  change(e:any) {
    this.isChecked = e.target.checked;
  }


}
