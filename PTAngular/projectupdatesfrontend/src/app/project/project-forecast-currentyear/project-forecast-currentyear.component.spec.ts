import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectForecastCurrentyearComponent } from './project-forecast-currentyear.component';

describe('ProjectForecastCurrentyearComponent', () => {
  let component: ProjectForecastCurrentyearComponent;
  let fixture: ComponentFixture<ProjectForecastCurrentyearComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectForecastCurrentyearComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectForecastCurrentyearComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
