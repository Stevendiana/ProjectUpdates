import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectRagComponent } from './project-rag.component';

describe('ProjectRagComponent', () => {
  let component: ProjectRagComponent;
  let fixture: ComponentFixture<ProjectRagComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectRagComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectRagComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
