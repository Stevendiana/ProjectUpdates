import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectBudgetFutureyearComponent } from './project-budget-futureyear.component';

describe('ProjectBudgetFutureyearComponent', () => {
  let component: ProjectBudgetFutureyearComponent;
  let fixture: ComponentFixture<ProjectBudgetFutureyearComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectBudgetFutureyearComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectBudgetFutureyearComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
