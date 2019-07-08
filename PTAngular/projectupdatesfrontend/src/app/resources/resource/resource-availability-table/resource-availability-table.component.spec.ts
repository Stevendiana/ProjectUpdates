import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourceAvailabilityTableComponent } from './resource-availability-table.component';

describe('ResourceAvailabilityTableComponent', () => {
  let component: ResourceAvailabilityTableComponent;
  let fixture: ComponentFixture<ResourceAvailabilityTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourceAvailabilityTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourceAvailabilityTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
