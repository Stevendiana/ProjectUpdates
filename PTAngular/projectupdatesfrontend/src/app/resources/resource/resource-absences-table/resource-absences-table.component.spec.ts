import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourceAbsencesTableComponent } from './resource-absences-table.component';

describe('ResourceAbsencesTableComponent', () => {
  let component: ResourceAbsencesTableComponent;
  let fixture: ComponentFixture<ResourceAbsencesTableComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourceAbsencesTableComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourceAbsencesTableComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
