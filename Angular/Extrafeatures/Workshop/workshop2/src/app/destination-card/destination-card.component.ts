import {
  Component,
  Input,
  Output,
  EventEmitter,
  OnChanges,
  SimpleChanges
} from '@angular/core';

import { CommonModule } from '@angular/common';
import { CurrencyPipe } from '@angular/common';

@Component({
  selector: 'app-destination-card',
  standalone: true,
  imports: [CommonModule, CurrencyPipe],
  templateUrl: './destination-card.component.html',
  styleUrls: ['./destination-card.component.css']
})
export class DestinationCardComponent implements OnChanges {

  @Input() destination: any;

  @Output() viewDestination = new EventEmitter<number>();

  viewDetails() {
    this.viewDestination.emit(this.destination.id);
  }

  ngOnChanges(changes: SimpleChanges): void {

    if (changes['destination']) {
      console.log("Destination Updated");
    }

  }

}