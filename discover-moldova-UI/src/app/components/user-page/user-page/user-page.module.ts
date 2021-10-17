import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaterialModule } from 'src/app/material/material.module';

import { UserPageComponent } from '../user-page.component';

@NgModule({
  declarations: [
    UserPageComponent
  ],
  imports: [
    CommonModule,
    MaterialModule
  ]
})
export class UserPageModule { }
