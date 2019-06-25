import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectActualComponent } from './project-actual.component';

describe('ProjectActualComponent', () => {
  let component: ProjectActualComponent;
  let fixture: ComponentFixture<ProjectActualComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectActualComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectActualComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
