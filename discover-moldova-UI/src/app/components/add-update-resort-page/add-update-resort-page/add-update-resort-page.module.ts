import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaterialModule } from 'src/app/material/material.module';

import { AddUpdateResortPageComponent } from '../add-update-resort-page.component';

@NgModule({
  declarations: [
    AddUpdateResortPageComponent
  ],
  imports: [
    CommonModule,
    MaterialModule
  ]
})
export class AddUpdateResortPageModule { }
