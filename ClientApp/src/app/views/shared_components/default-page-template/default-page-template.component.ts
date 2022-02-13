import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-default-page-template',
  templateUrl: './default-page-template.component.html',
  styleUrls: ['./default-page-template.component.scss']
})
export class DefaultPageTemplateComponent implements OnInit {

  @Input() pageTitle: string = 'Page ';
  @Input() extraText: string = ' in construction';
  @Input() pageText: string = '';
  @Input() btnText: string | undefined;
  @Input() btnRouteLink: string | undefined;

  constructor() { }

  ngOnInit(): void {
  }

}
