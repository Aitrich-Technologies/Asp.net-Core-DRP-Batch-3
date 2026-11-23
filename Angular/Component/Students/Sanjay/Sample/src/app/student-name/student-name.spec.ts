import { ComponentFixture, TestBed } from '@angular/core/testing';

import { StudentName } from './student-name';

describe('StudentName', () => {
  let component: StudentName;
  let fixture: ComponentFixture<StudentName>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [StudentName],
    }).compileComponents();

    fixture = TestBed.createComponent(StudentName);
    component = fixture.componentInstance;
    await fixture.whenStable();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
