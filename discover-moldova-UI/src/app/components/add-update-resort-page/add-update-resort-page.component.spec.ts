import { ComponentFixture, TestBed } from '@angular/core/testing';

import { AddUpdateResortPageComponent } from './add-update-resort-page.component';

describe('AddUpdateResortPageComponent', () => {
  let component: AddUpdateResortPageComponent;
  let fixture: ComponentFixture<AddUpdateResortPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ AddUpdateResortPageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(AddUpdateResortPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
