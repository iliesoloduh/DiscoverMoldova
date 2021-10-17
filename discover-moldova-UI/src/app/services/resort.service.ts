import { HttpClient, HttpHeaders } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { ResortViewModel } from '../models/resort/resort.model';

@Injectable({
  providedIn: 'root'
})
export class ResortService {

  constructor(private httpService: HttpClient) { }

  createResort(resort: ResortViewModel): Observable<{}>{
    const token = localStorage.getItem('token');
    return this.httpService.post("https://localhost:44376/api/resorts", resort, 
      { headers: new HttpHeaders({
        'Authorization':`Bearer ${token}`})
      });
  }
}
