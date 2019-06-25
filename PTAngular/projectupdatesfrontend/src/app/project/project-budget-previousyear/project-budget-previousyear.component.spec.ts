import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectBudgetPreviousyearComponent } from './project-budget-previousyear.component';

describe('ProjectBudgetPreviousyearComponent', () => {
  let component: ProjectBudgetPreviousyearComponent;
  let fixture: ComponentFixture<ProjectBudgetPreviousyearComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectBudgetPreviousyearComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectBudgetPreviousyearComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
