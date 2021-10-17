import { Component, Input, OnInit } from '@angular/core';

@Component({
  selector: 'app-user-page',
  templateUrl: './user-page.component.html',
  styleUrls: ['./user-page.component.css']
})
export class UserPageComponent implements OnInit {

  @Input()
  resort: {image: string, title: string, price: number, capacity: number} | undefined; 

  activities = [
  {
    act: "Manastirea Curchi"
  },
  { 
    act: "Costesti Stanca"
  },
  {
    act: "Lacul Danceni"
  },
  {
    act: "Orheiul Vechi"
  }];

  icons = [
  { 
    image: "https://cdn2.iconfinder.com/data/icons/flaticons-solid/18/wifi-rounded-1-512.png",
    text: "Free Wifi"
  },
  { 
    image: "https://www.clipartmax.com/png/middle/195-1954709_grill-free-icon-utensils-icon-transparent-background.png",
    text: "BBQ"
  },
  { 
    image: "https://www.vhv.rs/dpng/d/494-4944681_swim-swimming-pool-icon-png-transparent-png.png",
    text: "Swimming pool"
  },
  { 
    image: "https://www.freeiconspng.com/thumbs/parking-icon-png/parking-icon-png-18.png",
    text: "Free Parking"
  }];

  constructor() { }

  ngOnInit(): void {
  }

}
