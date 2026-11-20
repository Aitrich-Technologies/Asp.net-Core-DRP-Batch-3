import { Component } from '@angular/core';
import { TourService } from '../tour.service';
import { Tour } from '../tour';
import { ActivatedRoute, Router, RouterLink } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-tours',
  standalone: true,
  imports: [CommonModule, FormsModule, RouterLink],
  templateUrl: './tours.component.html',
})
export class ToursComponent {
  tours: Tour[] = [];
  filteredTours: Tour[] = [];
  search = '';

  constructor(
    private service: TourService,
    private route: ActivatedRoute,
    private router: Router,
  ) {
    this.tours = this.service.getTours();

    this.route.queryParams.subscribe((param) => {
      this.search = param['search'] || '';

      this.filter();
    });
  }

  filter() {
    this.filteredTours = this.tours.filter((x) =>
      x.name.toLowerCase().includes(this.search.toLowerCase()),
    );
  }

  onSearch() {
    this.router.navigate([], {
      queryParams: {
        search: this.search,
      },
    });
  }
}
