import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private router: Router) {

  }
  
  ngOnInit(): void {
  }

  isLoggedIn(): boolean {
    // var time =JSON.parse(localStorage.getItem('tokenExpireDate') ?? '');
    // var dateTime = new Date(time ?? '');
    // var curDate = new Date();
  //  localStorage.clear();

    if (localStorage.getItem('token') === null){
      return false;
    }

    // if (dateTime < curDate) {
    //   this.router.navigate(['/login']);
    //   return false;
    // }
    
    return true;
  }

  logout(){
    localStorage.clear();
    this.router.navigate(['/home']);
  }
}
