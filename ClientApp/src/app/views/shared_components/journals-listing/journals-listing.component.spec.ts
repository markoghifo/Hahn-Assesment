import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JournalsListingComponent } from './journals-listing.component';

describe('JournalsListingComponent', () => {
  let component: JournalsListingComponent;
  let fixture: ComponentFixture<JournalsListingComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ JournalsListingComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(JournalsListingComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
