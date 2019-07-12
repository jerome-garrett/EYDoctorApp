import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { routerNgProbeToken } from '@angular/router/src/router_module';
import { DoctorService } from '../services/doctor.service';
import { DoctorDetail } from '../interfaces/doctorDetail';

@Component({
  // tslint:disable-next-line:component-selector
  selector: 'DoctorDetail',
  templateUrl: './DoctorDetail.component.html',
  styleUrls: ['./DoctorDetail.component.css']
})
export class DoctorDetailComponent implements OnInit {
  doctorId: number;
  doctor: DoctorDetail;

  constructor(private route: ActivatedRoute, private router: Router, private doctorService: DoctorService) {
    route.params.subscribe(p => {
      this.doctorId = +p['id'];
      if (isNaN(this.doctorId) || this.doctorId <= 0) {
        router.navigate(['/home']);
        return;
      }
    });
  }

  ngOnInit() {
    this.doctorService.getDoctor(this.doctorId).subscribe(data => {
      this.doctor = data;
    });
  }

}
