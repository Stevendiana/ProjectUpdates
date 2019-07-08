import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourcesAbsencesTableComponent } from './resources-absences-table.component';

describe('ResourcesAbsencesTableComponent', () => {
  let component: ResourcesAbsencesTableComponent;
  let fixture: ComponentFixture<ResourcesAbsencesTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourcesAbsencesTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourcesAbsencesTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
