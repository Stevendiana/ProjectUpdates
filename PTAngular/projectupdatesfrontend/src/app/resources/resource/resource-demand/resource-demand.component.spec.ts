import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourceDemandComponent } from './resource-demand.component';

describe('ResourceDemandComponent', () => {
  let component: ResourceDemandComponent;
  let fixture: ComponentFixture<ResourceDemandComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourceDemandComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourceDemandComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
