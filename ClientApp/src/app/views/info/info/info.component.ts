import { Component, OnInit } from '@angular/core';
import { NavigationEnd, Router } from '@angular/router';

@Component({
  selector: 'app-info',
  templateUrl: './info.component.html',
  styleUrls: ['./info.component.scss']
})
export class InfoComponent implements OnInit {

  title: string = "";
  bgImgSrc: string = 'url(../../../../assets/images/info/peer-review.png)'

  constructor(private router: Router) {
    router.events.subscribe((val) => {
      // see also 
      if (val instanceof NavigationEnd) {
        if (val.url.indexOf('journal-information') > -1) {
          this.bgImgSrc = 'url(../../../../assets/images/info/journal-info.jpg)';
        } else if (val.url.indexOf('code-of-ethics') > -1) {
          this.bgImgSrc = 'url(../../../../assets/images/info/code-of-ethics.png)';
        } else if (val.url.indexOf('editorial-procedures') > -1) {
          this.bgImgSrc = 'url(../../../../assets/images/info/editorial-procedure.jpg)';
        } else if (val.url.indexOf('peer-review') > -1) {
          this.bgImgSrc = 'url(../../../../assets/images/info/peer-review.png)';
        }else if (val.url.indexOf('faq') > -1) {
          this.bgImgSrc = 'url(../../../../assets/images/info/faqs.jpg)';
        }
        // console.log(val.url, this.bgImgSrc)
      }
    });
  }

  ngOnInit(): void {
  }

}
