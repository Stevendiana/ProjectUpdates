import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectIssueComponent } from './project-issue.component';

describe('ProjectIssueComponent', () => {
  let component: ProjectIssueComponent;
  let fixture: ComponentFixture<ProjectIssueComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectIssueComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectIssueComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
