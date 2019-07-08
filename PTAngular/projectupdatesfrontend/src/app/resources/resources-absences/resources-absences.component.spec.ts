import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourcesAbsencesComponent } from './resources-absences.component';

describe('ResourcesAbsencesComponent', () => {
  let component: ResourcesAbsencesComponent;
  let fixture: ComponentFixture<ResourcesAbsencesComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourcesAbsencesComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourcesAbsencesComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
