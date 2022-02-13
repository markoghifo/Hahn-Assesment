import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { ArticlesPageComponent } from './views/articles-page/articles-page.component';
import { EditorsPageComponent } from './views/editors-page/editors-page.component';
import { FindPageComponent } from './views/find-page/find-page.component';
import { HomeComponent } from './views/home/home.component';
import { JournalsComponent } from './views/journals/journals.component';
import { PublishPageComponent } from './views/publish-page/publish-page.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: 'home',
    pathMatch: 'full'
  },
  {
    path: 'home',
    component: HomeComponent
  },
  {
    path: 'journals',
    component: JournalsComponent
  },
  {
    path: 'articles',
    component: ArticlesPageComponent
  },
  {
    path: 'find',
    component: FindPageComponent
  },
  {
    path: 'publish',
    component: PublishPageComponent
  },
  {
    path: 'editors',
    component: EditorsPageComponent
  },
  {
    path: 'auth',
    loadChildren: () => import('src/app/views/auth/auth.module').then(m => m.AuthModule)
  },
  {
    path: 'info',
    loadChildren: () => import('src/app/views/info/info.module').then(m => m.InfoModule)
  },
  {
    path: '**',
    redirectTo: 'home',
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {
    // Restore the last scroll position
    //scrollPositionRestoration: "enabled",
    //scrollOffset: [0, 0],
    // Enable scrolling to anchors
    scrollPositionRestoration: 'enabled',
    scrollOffset: [0, 0],
    // Enable scrolling to anchors
    anchorScrolling: 'enabled'
  })],
  exports: [RouterModule]
})
export class AppRoutingModule { }
