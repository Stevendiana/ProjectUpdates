import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourceAbsencesComponent } from './resource-absences.component';

describe('ResourceAbsencesComponent', () => {
  let component: ResourceAbsencesComponent;
  let fixture: ComponentFixture<ResourceAbsencesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourceAbsencesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourceAbsencesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
