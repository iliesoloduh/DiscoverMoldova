import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, CanActivate, Router, RouterStateSnapshot, UrlTree } from '@angular/router';
import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AutorizationGuard implements CanActivate {

  constructor(private router: Router){

  }

  canActivate(
    route: ActivatedRouteSnapshot,
    state: RouterStateSnapshot): Observable<boolean | UrlTree> | Promise<boolean | UrlTree> | boolean | UrlTree {
    //   var time =JSON.parse(localStorage.getItem('tokenExpireDate') ?? '');
    //   var dateTime = new Date(time ?? '');
    //   var curDate = new Date();
    //   console.log(dateTime < curDate);
        
    // if (dateTime < curDate) {
    //   return false;
    // }

    if (localStorage.getItem('token') !== null){
      return true;
    }
    else {
      this.router.navigate(['/login']);
      return false;
    }
  }
  
}
