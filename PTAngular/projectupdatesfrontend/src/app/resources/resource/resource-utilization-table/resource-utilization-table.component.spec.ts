import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourceUtilizationTableComponent } from './resource-utilization-table.component';

describe('ResourceUtilizationTableComponent', () => {
  let component: ResourceUtilizationTableComponent;
  let fixture: ComponentFixture<ResourceUtilizationTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourceUtilizationTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourceUtilizationTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
