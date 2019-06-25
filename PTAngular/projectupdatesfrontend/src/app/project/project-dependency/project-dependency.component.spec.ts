import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectDependencyComponent } from './project-dependency.component';

describe('ProjectDependencyComponent', () => {
  let component: ProjectDependencyComponent;
  let fixture: ComponentFixture<ProjectDependencyComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectDependencyComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectDependencyComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
