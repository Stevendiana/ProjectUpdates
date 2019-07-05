import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { SupportHowToDoGuideComponent } from './support-how-to-do-guide.component';

describe('SupportHowToDoGuideComponent', () => {
  let component: SupportHowToDoGuideComponent;
  let fixture: ComponentFixture<SupportHowToDoGuideComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ SupportHowToDoGuideComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(SupportHowToDoGuideComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
