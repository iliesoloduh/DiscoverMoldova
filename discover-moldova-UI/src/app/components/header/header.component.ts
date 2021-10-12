import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  isLoggedIn: boolean = localStorage.getItem('token') !== null;

  // metoda logout, in ea sterg token si user din localstorage, o  apelez la apelarea butonului logout
  constructor() { }

  ngOnInit(): void {
  }

}
