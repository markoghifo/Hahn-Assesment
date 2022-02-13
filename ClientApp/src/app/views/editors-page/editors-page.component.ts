import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-editors-page',
  templateUrl: './editors-page.component.html',
  styleUrls: ['./editors-page.component.scss']
})
export class EditorsPageComponent implements OnInit {

  editors: editor[] = [
    {
      companyName: 'ICAN',
      imgSrc: '../../../assets/images/editors/editor1.png',
      name: 'Jana Faganeli Pucer',
      title: 'Lead Editor'
    },
    {
      companyName: 'GTB',
      imgSrc: '../../../assets/images/editors/editor2.png',
      name: 'Lindsay Katsonogerir',
      title: 'Business Analyst'
    },
    {
      companyName: 'NSE',
      imgSrc: '../../../assets/images/editors/editor3.png',
      name: 'Tanja Bivic Plankar',
      title: 'Stock and Trade Analyst'
    },
    {
      companyName: 'Zenith',
      imgSrc: '../../../assets/images/editors/editor4.png',
      name: 'Ana Slavec',
      title: 'CFO'
    },
    {
      companyName: 'First Bank',
      imgSrc: '../../../assets/images/editors/editor5.png',
      name: 'Jana Faganeli Pucer',
      title: 'DMD'
    },
    {
      companyName: 'Stears',
      imgSrc: '../../../assets/images/editors/editor6.png',
      name: 'Williams Smith',
      title: 'CEO'
    },
    {
      companyName: 'ICAN',
      imgSrc: '../../../assets/images/editors/editor1.png',
      name: 'Jana Faganeli Pucer',
      title: 'Lead Editor'
    },
    {
      companyName: 'GTB',
      imgSrc: '../../../assets/images/editors/editor2.png',
      name: 'Lindsay Katsonogerir',
      title: 'Business Analyst'
    },
    {
      companyName: 'NSE',
      imgSrc: '../../../assets/images/editors/editor3.png',
      name: 'Tanja Bivic Plankar',
      title: 'Stock and Trade Analyst'
    },
    {
      companyName: 'Zenith',
      imgSrc: '../../../assets/images/editors/editor4.png',
      name: 'Ana Slavec',
      title: 'CFO'
    },
    {
      companyName: 'First Bank',
      imgSrc: '../../../assets/images/editors/editor5.png',
      name: 'Jana Faganeli Pucer',
      title: 'DMD'
    },
    {
      companyName: 'Stears',
      imgSrc: '../../../assets/images/editors/editor6.png',
      name: 'Williams Smith',
      title: 'CEO'
    }
  ];

  constructor() { }

  ngOnInit(): void {
  }

}

interface editor {
  imgSrc: string
  name: string
  title: string
  companyName: string
}
