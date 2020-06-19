import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HeaderComponent } from './components/header/header.component';


const ROUTES: Routes = [
  {path: '', component: HeaderComponent },
  {path: 'Header', component: HeaderComponent },
  {path: '**', component: HeaderComponent },
];

@NgModule({
  imports: [RouterModule.forRoot(ROUTES)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
