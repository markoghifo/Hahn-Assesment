import { CommonModule } from '@angular/common';
import { NgModule } from '@angular/core';
import { RouterModule } from '@angular/router';
import { DefaultPageTemplateComponent } from './default-page-template/default-page-template.component';
import { JournalsListingComponent } from './journals-listing/journals-listing.component';

@NgModule({
  declarations: [
    DefaultPageTemplateComponent,
    JournalsListingComponent
  ],
  imports: [
    CommonModule,
    RouterModule
  ],
  providers: [],
  exports: [DefaultPageTemplateComponent, JournalsListingComponent]
})
export class SharedModule { }
