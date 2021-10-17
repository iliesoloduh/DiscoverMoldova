import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { FacilityViewModel } from '../models/facility.model';

@Injectable({
  providedIn: 'root'
})
export class FacilityService {

  constructor(private httpService: HttpClient) { }

  getAllFacilities(): Observable<FacilityViewModel[]>{
    return this.httpService.get<FacilityViewModel[]>("https://localhost:44376/api/facilities");
  }
}
