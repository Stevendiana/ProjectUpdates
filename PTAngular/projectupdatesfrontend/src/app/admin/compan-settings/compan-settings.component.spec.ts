import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CompanSettingsComponent } from './compan-settings.component';

describe('CompanSettingsComponent', () => {
  let component: CompanSettingsComponent;
  let fixture: ComponentFixture<CompanSettingsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CompanSettingsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CompanSettingsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
