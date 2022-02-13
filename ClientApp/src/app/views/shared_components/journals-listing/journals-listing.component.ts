import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-journals-listing',
  templateUrl: './journals-listing.component.html',
  styleUrls: ['./journals-listing.component.scss']
})
export class JournalsListingComponent implements OnInit {
    
  journals: journal[] = [
    {
      icon: 'users.png',
      excerpt: 'Euismod faucibus turpis eu gravida mi. Pellentesque et velit aliquam sed faucib turpis eu gravida mi. Pellentesque et velit aliquam sed mi. ',
      title: 'Financial Accounting'
    }, {
      icon: 'mark.png',
      excerpt: 'Euismod faucibus turpis eu gravida mi. Pellentesque et velit aliquam sed faucib turpis eu gravida mi. Pellentesque et velit aliquam sed mi. ',
      title: 'Management Accounting & Controls'
    }, {
      icon: 'audit.png',
      excerpt: 'Euismod faucibus turpis eu gravida mi. Pellentesque et velit aliquam sed faucib turpis eu gravida mi. Pellentesque et velit aliquam sed mi. ',
      title: 'Audit and Assurance'
    }, {
      icon: 'faq.png',
      excerpt: 'Euismod faucibus turpis eu gravida mi. Pellentesque et velit aliquam sed faucib turpis eu gravida mi. Pellentesque et velit aliquam sed mi. ',
      title: 'Public Sector Accounting & Accountability'
    }, {
      icon: 'stop-watch.png',
      excerpt: 'Euismod faucibus turpis eu gravida mi. Pellentesque et velit aliquam sed faucib turpis eu gravida mi. Pellentesque et velit aliquam sed mi. ',
      title: 'Ethical Issues in Accounting and Finance'
    }, {
      icon: 'edit-article.png',
      excerpt: 'Euismod faucibus turpis eu gravida mi. Pellentesque et velit aliquam sed faucib turpis eu gravida mi. Pellentesque et velit aliquam sed mi. ',
      title: 'Standard Setting Accounting Regulations'
    }, {
      icon: 'users.png',
      excerpt: 'Euismod faucibus turpis eu gravida mi. Pellentesque et velit aliquam sed faucib turpis eu gravida mi. Pellentesque et velit aliquam sed mi. ',
      title: 'Development in Accounting '
    }, {
      icon: 'mark.png',
      excerpt: 'Euismod faucibus turpis eu gravida mi. Pellentesque et velit aliquam sed faucib turpis eu gravida mi. Pellentesque et velit aliquam sed mi. ',
      title: 'Information Systems'
    }, {
      icon: 'audit.png',
      excerpt: 'Euismod faucibus turpis eu gravida mi. Pellentesque et velit aliquam sed faucib turpis eu gravida mi. Pellentesque et velit aliquam sed mi. ',
      title: 'Capital Markets'
    }, {
      icon: 'faq.png',
      excerpt: 'Euismod faucibus turpis eu gravida mi. Pellentesque et velit aliquam sed faucib turpis eu gravida mi. Pellentesque et velit aliquam sed mi. ',
      title: 'Corporate Finance'
    }, {
      icon: 'stop-watch.png',
      excerpt: 'Euismod faucibus turpis eu gravida mi. Pellentesque et velit aliquam sed faucib turpis eu gravida mi. Pellentesque et velit aliquam sed mi. ',
      title: 'Financial Institutions'
    }, {
      icon: 'edit-article.png',
      excerpt: 'Euismod faucibus turpis eu gravida mi. Pellentesque et velit aliquam sed faucib turpis eu gravida mi. Pellentesque et velit aliquam sed mi. ',
      title: 'Financial Management'
    }, {
      icon: 'faq.png',
      excerpt: 'Euismod faucibus turpis eu gravida mi. Pellentesque et velit aliquam sed faucib turpis eu gravida mi. Pellentesque et velit aliquam sed mi. ',
      title: 'Financial Planning '
    }, {
      icon: 'stop-watch.png',
      excerpt: 'Euismod faucibus turpis eu gravida mi. Pellentesque et velit aliquam sed faucib turpis eu gravida mi. Pellentesque et velit aliquam sed mi. ',
      title: 'Commercial Law'
    }, {
      icon: 'edit-article.png',
      excerpt: 'Euismod faucibus turpis eu gravida mi. Pellentesque et velit aliquam sed faucib turpis eu gravida mi. Pellentesque et velit aliquam sed mi. ',
      title: 'Behavioural Financial '
    }
  ];

  constructor() { }

  ngOnInit(): void {
  }

}

interface journal {
  icon: string,
  title: string,
  excerpt: string
}
