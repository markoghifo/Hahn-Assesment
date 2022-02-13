import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
  styleUrls: ['./home.component.scss']
})
export class HomeComponent implements OnInit {

  imgSrcs: string[] = [
    '../../../assets/images/home-page/expert-face-1.png',
    '../../../assets/images/home-page/expert-face-2.png',
    '../../../assets/images/home-page/expert-face-3.png',
    '../../../assets/images/home-page/expert-face-4.png',
    '../../../assets/images/home-page/expert-face-5.png',
    '../../../assets/images/home-page/expert-face-6.png'
  ]

  features: feature[] = [
    {
      iconSrc: '../../../assets/images/icons/article.png',
      title: 'Editorial Procedure',
      body: 'All authors will receive notification of acknowledgment comprising a Manuscript ID upon the receipt of the submission, and the Editorial decision concerning publication.',
      bgColor: '#5B72EE'
    },
    {
      iconSrc: '../../../assets/images/icons/calendar.png',
      title: "The IJCAI's Peer-Review Procedure",
      body: "The peer review process serves the purpose of improving the reporting of research as well as identifying the most appropriate and highest quality material for the review.",
      bgColor: '#F48C06'
    },
    {
      iconSrc: '../../../assets/images/icons/users.png',
      title: 'Code of Ethics',
      body: "The IJCAI and V/I Publishers consider and reflect in its publication the highest ethical considerations.",
      bgColor: '#29B9E7'
    }
  ]

  constructor() { }

  ngOnInit(): void {
  }

}

interface feature {
  iconSrc: string,
  bgColor: string,
  title: string,
  body: string
}

