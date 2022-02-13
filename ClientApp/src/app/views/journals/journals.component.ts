import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-journals',
  templateUrl: './journals.component.html',
  styleUrls: ['./journals.component.scss']
})
export class JournalsComponent implements OnInit {

  workStyles: string[] = [
    'Quality Criteria Evaluation',
    'Peer Review',
    'Find Journal',
    'Publish Journal'
  ];

  journals: any[] = [1, 2, 3.4]

  constructor() { }

  ngOnInit(): void {
  }

}

