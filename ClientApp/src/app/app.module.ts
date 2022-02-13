import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';
import { HomeComponent } from './views/home/home.component';
import { FooterComponent } from './views/shared_components/footer/footer.component';
import { HeaderComponent } from './views/shared_components/header/header.component';
import { JournalsComponent } from './views/journals/journals.component';
import { SingleJournalCardComponent } from './views/journals/single-journal-card/single-journal-card.component';
import { PublishPageComponent } from './views/publish-page/publish-page.component';
import { ArticlesPageComponent } from './views/articles-page/articles-page.component';
import { FindPageComponent } from './views/find-page/find-page.component';
import { HttpClientModule } from '@angular/common/http';
import { EditorsPageComponent } from './views/editors-page/editors-page.component';
import { SharedModule } from './views/shared_components/shared.module';

@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    FooterComponent,
    HeaderComponent,
    JournalsComponent,
    SingleJournalCardComponent,
    PublishPageComponent,
    ArticlesPageComponent,
    FindPageComponent,
    EditorsPageComponent,
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    NgbModule,
    SharedModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
