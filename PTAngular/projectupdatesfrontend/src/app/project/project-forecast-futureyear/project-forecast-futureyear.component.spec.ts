import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProjectForecastFutureyearComponent } from './project-forecast-futureyear.component';

describe('ProjectForecastFutureyearComponent', () => {
  let component: ProjectForecastFutureyearComponent;
  let fixture: ComponentFixture<ProjectForecastFutureyearComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProjectForecastFutureyearComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProjectForecastFutureyearComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
