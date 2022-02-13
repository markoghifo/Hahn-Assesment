import { Component, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';

@Component({
    selector: 'app-journals',
    templateUrl: './auth.component.html',
    styleUrls: ['./auth.component.scss']
})
export class AuthComponent implements OnInit {

    stepNo: string = '';
    stepText: string = '';
    pageTitle: string = '';
    pagePretext: string = '';

    constructor(private router: Router) {
        router.events.subscribe((val) => {
          // see also 
          if (val instanceof NavigationEnd) {
            if (val.url.indexOf('register') > -1) {
              this.stepNo = '01/03';
              this.stepText = 'Create Profile';
              this.pageTitle = 'Register Individual Account!';
              this.pagePretext = 'For the purpose of industry regulation, your details are required.';
            } else if (val.url.indexOf('login') > -1) {
                this.stepNo = '02/03';
                this.stepText = 'Access Point';
                this.pageTitle = 'Login Individual Account!';
                this.pagePretext = 'Access user specific data and or functionalities';
            } else if (val.url.indexOf('edit-profile') > -1) {
                this.stepNo = '03/03';
                this.stepText = 'Update Profile';
                this.pageTitle = 'Update Individual Account!';
                this.pagePretext = 'For the purpose of industry regulation, kindly ensure your details are valid (authentic) and up to date.';
            }
            // console.log(val.url, this.bgImgSrc)
          }
        });
    }

    ngOnInit(): void {
    }

}

