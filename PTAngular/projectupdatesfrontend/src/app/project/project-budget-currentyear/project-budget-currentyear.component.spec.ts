import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectBudgetCurrentyearComponent } from './project-budget-currentyear.component';

describe('ProjectBudgetCurrentyearComponent', () => {
  let component: ProjectBudgetCurrentyearComponent;
  let fixture: ComponentFixture<ProjectBudgetCurrentyearComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectBudgetCurrentyearComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectBudgetCurrentyearComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
