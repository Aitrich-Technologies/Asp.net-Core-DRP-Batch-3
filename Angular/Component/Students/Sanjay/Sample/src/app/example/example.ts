// import { Component, OnInit } from '@angular/core';


// @Component({
//   selector: 'app-example',
//   imports: [],
//   templateUrl: './example.html',
//   styleUrl: './example.css',
// })
// export class Example implements OnInit {
//   Title:string = '';

//   ngOnInit() {
//     this.Title = 'Welcome to Angular';
//   }
// }


import { Component, Input, OnChanges, SimpleChanges } from '@angular/core';
@Component({
  selector: 'app-example',
  template: `<p>{{ name }}</p>`
})
export class Example implements OnChanges {
  @Input() name = '';
  ngOnChanges(changes: SimpleChanges) {
    console.log('Input value changed', changes);
  }
}