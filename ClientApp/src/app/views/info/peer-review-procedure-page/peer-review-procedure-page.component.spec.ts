import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PeerReviewProcedurePageComponent } from './peer-review-procedure-page.component';

describe('PeerReviewProcedurePageComponent', () => {
  let component: PeerReviewProcedurePageComponent;
  let fixture: ComponentFixture<PeerReviewProcedurePageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PeerReviewProcedurePageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PeerReviewProcedurePageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
