import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UploadCentreComponent } from './upload-centre.component';

describe('UploadCentreComponent', () => {
  let component: UploadCentreComponent;
  let fixture: ComponentFixture<UploadCentreComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UploadCentreComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UploadCentreComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
