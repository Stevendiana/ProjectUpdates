import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectForecastPreviousyearComponent } from './project-forecast-previousyear.component';

describe('ProjectForecastPreviousyearComponent', () => {
  let component: ProjectForecastPreviousyearComponent;
  let fixture: ComponentFixture<ProjectForecastPreviousyearComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectForecastPreviousyearComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectForecastPreviousyearComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
