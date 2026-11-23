import { Component, OnDestroy } from '@angular/core';

@Component({
  selector: 'app-destroy-component',
  imports: [],
  template: `<p>Example component</p>`,
})
export class DestroyComponent implements OnDestroy {
    ngOnDestroy() {
    console.log('Goodbye! Component destroyed.');
  }
}
