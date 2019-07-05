import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourceUserComponent } from './resource-user.component';

describe('ResourceUserComponent', () => {
  let component: ResourceUserComponent;
  let fixture: ComponentFixture<ResourceUserComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourceUserComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourceUserComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
