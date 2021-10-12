import { VIRTUAL_SCROLL_STRATEGY } from '@angular/cdk/scrolling';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-resort-list',
  templateUrl: './resort-list.component.html',
  styleUrls: ['./resort-list.component.css']
})
export class ResortListComponent implements OnInit {
  resorts = [
    {
      image: "https://www.familyhandyman.com/wp-content/uploads/2021/02/GettyImages-157558914.jpg",
      title: "Eco Villa",
      price: 250,
      capacity: 50
    },
    {
      image: "https://images.unsplash.com/photo-1582719508461-905c673771fd?ixid=MnwxMjA3fDB8MHxzZWFyY2h8MXx8cmVzb3J0fGVufDB8fDB8fA%3D%3D&ixlib=rb-1.2.1&w=1000&q=80",
      title: "Luca's House",
      price: 200,
      capacity: 100
    },
    {
      image: "https://www.sleepermagazine.com/wp-content/uploads/2014/09/368525.jpg",
      title: "Hotel Prietenia",
      price: 350,
      capacity: 150
    },
    {
      image: "https://imgmedia.lbb.in/media/2019/10/5d972bf0e5ed8865a1b16c93_1570188272976.jpg",
      title: "Cabana Miorita",
      price: 325,
      capacity: 300
    },
    {
      image: "https://dynamic-media-cdn.tripadvisor.com/media/photo-o/1a/d5/9c/b8/stone-wood-nature-resort.jpg?w=900&h=-1&s=1",
      title: "Pensiunea La Ion",
      price: 150,
      capacity: 80
    }
  ];

  constructor() { }

  ngOnInit(): void {
  }

}
