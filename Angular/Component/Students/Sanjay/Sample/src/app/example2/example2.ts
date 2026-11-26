import { Component,Input, OnChanges, SimpleChanges } from '@angular/core';

@Component({
  selector: 'app-example2',
  imports: [],
  template: `<p>Example2 component works!</p>
    <p>Age: {{ age }}</p>
  `,
  styleUrl: './example2.css',
})
export class Example2 implements OnChanges {
  @Input() age = '';
  ngOnChanges(changes: SimpleChanges) {
    console.log('changed value',changes);
  }
}
