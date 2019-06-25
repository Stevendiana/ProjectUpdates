import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectActionLogComponent } from './project-action-log.component';

describe('ProjectActionLogComponent', () => {
  let component: ProjectActionLogComponent;
  let fixture: ComponentFixture<ProjectActionLogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectActionLogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectActionLogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
