import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourceResourceComponent } from './resource-resource.component';

describe('ResourceResourceComponent', () => {
  let component: ResourceResourceComponent;
  let fixture: ComponentFixture<ResourceResourceComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourceResourceComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourceResourceComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
