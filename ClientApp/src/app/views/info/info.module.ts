import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { InfoRoutingModule } from './info-routing.module';
import { InfoComponent } from './info/info.component';
import { PeerReviewProcedurePageComponent } from './peer-review-procedure-page/peer-review-procedure-page.component';
import { CodeOfEthicsPageComponent } from './code-of-ethics-page/code-of-ethics-page.component';
import { EditorialPageComponent } from './editorial-page/editorial-page.component';
import { JournalInformationPageComponent } from './journal-information-page/journal-information-page.component';
import { FaqComponent } from './faq/faq.component';
import { SharedModule } from '../shared_components/shared.module';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';


@NgModule({
  declarations: [
    InfoComponent,
    PeerReviewProcedurePageComponent,
    CodeOfEthicsPageComponent,
    EditorialPageComponent,
    JournalInformationPageComponent,
    FaqComponent
  ],
  imports: [
    CommonModule,
    InfoRoutingModule,
    NgbModule,
    SharedModule
  ]
})
export class InfoModule { }
