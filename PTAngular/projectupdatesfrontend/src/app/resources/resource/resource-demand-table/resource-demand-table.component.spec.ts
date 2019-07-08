import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourceDemandTableComponent } from './resource-demand-table.component';

describe('ResourceDemandTableComponent', () => {
  let component: ResourceDemandTableComponent;
  let fixture: ComponentFixture<ResourceDemandTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourceDemandTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourceDemandTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
