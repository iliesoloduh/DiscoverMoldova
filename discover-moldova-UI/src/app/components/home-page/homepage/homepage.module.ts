import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { MaterialModule } from 'src/app/material/material.module';

import { HomePageComponent } from '../home-page/home-page.component';
import { FilterOptionsComponent } from '../filter-options/filter-options.component';
import { SearchBarComponent } from '../search-bar/search-bar.component';
import { ResortListComponent } from '../resort-list/resort-list.component';
import { ResortItemComponent } from '../resort-list/resort-item/resort-item.component';

@NgModule({
  declarations: [
    HomePageComponent,
    FilterOptionsComponent,
    SearchBarComponent,
    ResortListComponent,
    ResortItemComponent
  ],
  imports: [
    CommonModule,
    MaterialModule
  ],
  exports: [
  ]
})
export class HomepageModule { }
