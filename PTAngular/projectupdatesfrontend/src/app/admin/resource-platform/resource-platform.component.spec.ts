import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ResourcePlatformComponent } from './resource-platform.component';

describe('ResourcePlatformComponent', () => {
  let component: ResourcePlatformComponent;
  let fixture: ComponentFixture<ResourcePlatformComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ResourcePlatformComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ResourcePlatformComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
