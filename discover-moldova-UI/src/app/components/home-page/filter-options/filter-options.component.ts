import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-filter-options',
  templateUrl: './filter-options.component.html',
  styleUrls: ['./filter-options.component.css']
})
export class FilterOptionsComponent implements OnInit {
  facilities: string[] = ['Wifi', "Parking", "Pool", "Biliard", "Tenis", "BBQ"];
  activities: string[] = ['Monasteries', "Hiking", "Sightseeing", "Entertaiment", "Fishing"];

  max = 1000;
  min = 0;
  step = 10;
  thumbLabel = true;
  value = 0;

  constructor() { }

  ngOnInit(): void {
  }
}
