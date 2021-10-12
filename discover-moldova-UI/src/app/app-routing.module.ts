import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { HomePageComponent } from './components/home-page/home-page/home-page.component';
import { LoginPageComponent } from './components/login-page/login-page.component';
import { RegisterPageComponent } from './components/register-page/register-page.component';
import { ResortPageComponent } from './components/resort-page/resort-page.component';
import { AddUpdateResortPageComponent } from './components/add-update-resort-page/add-update-resort-page.component';

const routes: Routes = [
  { path: 'login', component: LoginPageComponent },
  { path: 'signup', component: RegisterPageComponent },
  { path: 'home', component: HomePageComponent },
  { path: 'resort', component: ResortPageComponent },
  { path: 'resortAddOrUpdate', component: AddUpdateResortPageComponent},
  { path: '', component: HomePageComponent }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
