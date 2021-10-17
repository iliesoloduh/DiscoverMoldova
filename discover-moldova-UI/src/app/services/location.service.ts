import { HttpClient } from '@angular/common/http';
import { Injectable } from '@angular/core';
import { Observable } from 'rxjs';
import { DistrictViewModel } from '../models/location/district.model';
import { LocationViewModel } from '../models/location/location.model';

@Injectable({
  providedIn: 'root'
})
export class LocationService {

  constructor(private httpService: HttpClient) { }

  getAllDistricts(): Observable<DistrictViewModel[]>{
    return this.httpService.get<DistrictViewModel[]>("https://localhost:44376/api/districts");
  }

  getLocationsByDistrictId(id: number): Observable<LocationViewModel[]> {
    return this.httpService.get<LocationViewModel[]>(`https://localhost:44376/api/districts/${id}/locations`);
  }
}
