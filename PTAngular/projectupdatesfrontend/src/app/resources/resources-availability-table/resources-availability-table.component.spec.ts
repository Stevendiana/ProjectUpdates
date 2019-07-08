import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourcesAvailabilityTableComponent } from './resources-availability-table.component';

describe('ResourcesAvailabilityTableComponent', () => {
  let component: ResourcesAvailabilityTableComponent;
  let fixture: ComponentFixture<ResourcesAvailabilityTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourcesAvailabilityTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourcesAvailabilityTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
