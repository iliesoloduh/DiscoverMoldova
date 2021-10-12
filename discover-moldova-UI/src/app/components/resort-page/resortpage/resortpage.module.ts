import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaterialModule } from 'src/app/material/material.module';
import { NgImageSliderModule } from 'ng-image-slider';

import { ResortPageComponent } from '../resort-page.component';

@NgModule({
  declarations: [
    ResortPageComponent
  ],
  imports: [
    CommonModule,
    MaterialModule,
    NgImageSliderModule
  ]
})
export class ResortpageModule { }
