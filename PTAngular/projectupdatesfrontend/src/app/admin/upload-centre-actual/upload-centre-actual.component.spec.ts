import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { UploadCentreActualComponent } from './upload-centre-actual.component';

describe('UploadCentreActualComponent', () => {
  let component: UploadCentreActualComponent;
  let fixture: ComponentFixture<UploadCentreActualComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ UploadCentreActualComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(UploadCentreActualComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
