import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourcesDemandTableComponent } from './resources-demand-table.component';

describe('ResourcesDemandTableComponent', () => {
  let component: ResourcesDemandTableComponent;
  let fixture: ComponentFixture<ResourcesDemandTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourcesDemandTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourcesDemandTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
