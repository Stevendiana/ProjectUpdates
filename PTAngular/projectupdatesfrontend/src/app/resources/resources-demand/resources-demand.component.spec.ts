import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourcesDemandComponent } from './resources-demand.component';

describe('ResourcesDemandComponent', () => {
  let component: ResourcesDemandComponent;
  let fixture: ComponentFixture<ResourcesDemandComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourcesDemandComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourcesDemandComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
