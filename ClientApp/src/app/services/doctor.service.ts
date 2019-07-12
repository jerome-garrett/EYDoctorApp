import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { DoctorSummary } from '../interfaces/doctorSummary.ts';
import { DoctorDetail } from '../interfaces/doctorDetail';

@Injectable({
  providedIn: 'root'
})
export class DoctorService {
  baseUrl = environment.apiUrl + 'doctors/';

  constructor(private http: HttpClient) { }

  getDoctors(): Observable<DoctorSummary[]> {
    return this.http.get<DoctorSummary[]>(this.baseUrl);
  }

  getDoctor(id: number): Observable<DoctorDetail> {
    return this.http.get<DoctorDetail>(this.baseUrl + id);
  }

}
