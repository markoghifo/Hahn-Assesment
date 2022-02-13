import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CodeOfEthicsPageComponent } from './code-of-ethics-page/code-of-ethics-page.component';
import { EditorialPageComponent } from './editorial-page/editorial-page.component';
import { FaqComponent } from './faq/faq.component';
import { InfoComponent } from './info/info.component';
import { JournalInformationPageComponent } from './journal-information-page/journal-information-page.component';
import { PeerReviewProcedurePageComponent } from './peer-review-procedure-page/peer-review-procedure-page.component';

const routes: Routes = [
  {
    path: '',
    component: InfoComponent,
    children: [
      {
        path: 'code-of-ethics',
        component: CodeOfEthicsPageComponent
      },
      {
        path: 'editorial-procedures',
        component: EditorialPageComponent
      },
      {
        path: 'journal-information',
        component: JournalInformationPageComponent
      },
      {
        path: 'peer-review',
        component: PeerReviewProcedurePageComponent
      },
      {
        path: 'faq',
        component: FaqComponent
      }
    ]
  }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class InfoRoutingModule { }
