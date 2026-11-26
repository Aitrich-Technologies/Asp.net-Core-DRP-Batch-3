import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { ActivatedRoute, Router } from '@angular/router';
import { DestinationService } from '../../services/destination.service';

@Component({
  selector: 'app-destination-form',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './destination-form.component.html',
  styleUrl: './destination-form.component.css'
})
export class DestinationFormComponent implements OnInit {

  destinationForm!: FormGroup;
  isEditMode = false;
  destinationId = 0;

  constructor(
    private fb: FormBuilder,
    private destinationService: DestinationService,
    private router: Router,
    private route: ActivatedRoute
  ) {}

  ngOnInit(): void {
    // Build the reactive form — one line per field, one validator per field
    this.destinationForm = this.fb.group({
      name: ['', Validators.required],
      country: ['', Validators.required],
      description: ['', Validators.required],
      startingPrice: ['', Validators.required],
      rating: ['', Validators.required],
      imageUrl: ['', Validators.required]
    });

    const idParam = this.route.snapshot.paramMap.get('id');
    if (idParam) {
      this.isEditMode = true;
      this.destinationId = Number(idParam);
      const existing = this.destinationService.getById(this.destinationId);
      if (existing) {
        this.destinationForm.patchValue(existing);
      }
    }
  }

  // Helper used in the template to show/hide error messages
  isInvalid(field: string): boolean {
    const control = this.destinationForm.get(field);
    return !!control && control.invalid && control.touched;
  }

  onSubmit(): void {
    if (this.destinationForm.invalid) {
      this.destinationForm.markAllAsTouched();
      return;
    }

    const destination = { id: this.destinationId, ...this.destinationForm.value };

    if (this.isEditMode) {
      this.destinationService.update(destination);
    } else {
      this.destinationService.add(destination);
    }

    this.router.navigate(['/destinations']);
  }

  onCancel(): void {
    this.router.navigate(['/destinations']);
  }
}
