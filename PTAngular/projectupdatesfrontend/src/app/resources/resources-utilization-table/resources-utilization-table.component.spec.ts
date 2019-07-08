import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourcesUtilizationTableComponent } from './resources-utilization-table.component';

describe('ResourcesUtilizationTableComponent', () => {
  let component: ResourcesUtilizationTableComponent;
  let fixture: ComponentFixture<ResourcesUtilizationTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourcesUtilizationTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourcesUtilizationTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
