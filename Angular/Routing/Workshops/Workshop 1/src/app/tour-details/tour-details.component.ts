import { Component } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { TourService } from '../tour.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-tour-details',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './tour-details.component.html',
})
export class TourDetailsComponent {
  tour: any;

  constructor(
    private route: ActivatedRoute,
    private service: TourService,
  ) {
    let id = Number(this.route.snapshot.paramMap.get('id'));

    this.tour = this.service.getTour(id);
  }
}
