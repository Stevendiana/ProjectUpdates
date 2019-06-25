import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectAssumptionComponent } from './project-assumption.component';

describe('ProjectAssumptionComponent', () => {
  let component: ProjectAssumptionComponent;
  let fixture: ComponentFixture<ProjectAssumptionComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectAssumptionComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectAssumptionComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
