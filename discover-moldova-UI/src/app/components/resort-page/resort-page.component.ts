import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-resort-page',
  templateUrl: './resort-page.component.html',
  styleUrls: ['./resort-page.component.css']
})
export class ResortPageComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  resort = {
    name: 'Eco Villa',
    address: 'Miron Costin 14',
    district: 'Orhei',
    location: 'Ivancea',
    email: 'ecovilla@gmail.com',
    phone: '079445566',
    description: `Bine aţi venit la pensiunea turistică EcoVila - locul perfect pentru distracţii cu prietenii, evenimente importante, dar şi odihnă cu familia. 
              Nimic nu poate fi mai bun decît un răgaz pe meleagurile mirifice ale Orheiului Vechi, printre salcîmii şi stejarii seculari care calmează şi în acelaşi timp, emană o energie deosebită, înzestrînd cu puteri noi toată fiinţa din jur.
              Suntem dispuşi să organizăm orice tip de festivitate la cel mai înalt nivel şi în orice perioadă a anului. Vă aşteptăm cu drag!
              NOTA: Accesul pe teritoriu cu bucate și băuturi este strict interzis.
              Acces pe teritoriul pensiunii au doar clienţii cazaţi.
              Vă mulțumim pentru înțelegere!`,
    price: 500,
    capacity: 100
  };

  locationIcon = "https://www.iconpacks.net/icons/1/free-pin-icon-48-thumb.png";
  emailIcon = "https://www.iconpacks.net/icons/2/free-icon-mail-2569.png";
  phoneIcon = "https://www.iconpacks.net/icons/1/free-icon-phone-504.png";
  priceIcon = "https://www.iconpacks.net/icons/3/free-cash-money-icon-6361.png";
  capacityIcon = "https://www.iconpacks.net/icons/3/free-icon-team-5704.png";

  facilityIcons = [
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

  imageObject = [{
    image: 'https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0e/4b/7b/08/swimming-pool-area.jpg?w=2000&h=-1&s=1',
    thumbImage: 'https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0e/4b/7b/08/swimming-pool-area.jpg?w=2000&h=-1&s=1'
  },
  {
    image: 'https://dynamic-media-cdn.tripadvisor.com/media/photo-o/13/bb/63/db/piscina-hotel-1898.jpg?w=1400&h=-1&s=1',
    thumbImage: 'https://dynamic-media-cdn.tripadvisor.com/media/photo-o/13/bb/63/db/piscina-hotel-1898.jpg?w=1400&h=-1&s=1'
  },
  {
    image: 'https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0e/4b/1c/34/deluxe-room.jpg?w=2000&h=-1&s=1',
    thumbImage: 'https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0e/4b/1c/34/deluxe-room.jpg?w=2000&h=-1&s=1'
  },
  {
    image: 'https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0e/4b/18/ae/privilege-room.jpg?w=2000&h=-1&s=1',
    thumbImage: 'https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0e/4b/18/ae/privilege-room.jpg?w=2000&h=-1&s=1'
  },
  {
    image: 'https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0e/4b/35/a7/hall-area.jpg?w=2000&h=-1&s=1',
    thumbImage: 'https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0e/4b/35/a7/hall-area.jpg?w=2000&h=-1&s=1'
  },
  {
    image: 'https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0e/4b/1c/44/deluxe-room-terrace.jpg?w=2000&h=-1&s=1',
    thumbImage: 'https://dynamic-media-cdn.tripadvisor.com/media/photo-o/0e/4b/1c/44/deluxe-room-terrace.jpg?w=2000&h=-1&s=1'
  }];
}
