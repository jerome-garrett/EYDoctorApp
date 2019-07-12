import { Component, OnInit } from '@angular/core';
import { DoctorService } from '../services/doctor.service';
import { DoctorSummary } from '../interfaces/doctorSummary.ts';

@Component({
  selector: 'app-home',
  templateUrl: './home.component.html',
})
export class HomeComponent implements OnInit {
  doctors: DoctorSummary[];

  constructor(private doctorService: DoctorService) {}

  ngOnInit(): void {
    this.doctorService.getDoctors().subscribe(data => this.doctors = data);
  }
}
