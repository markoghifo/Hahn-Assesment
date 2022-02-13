import { ComponentFixture, TestBed } from '@angular/core/testing';

import { SingleJournalCardComponent } from './single-journal-card.component';

describe('SingleJournalCardComponent', () => {
  let component: SingleJournalCardComponent;
  let fixture: ComponentFixture<SingleJournalCardComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ SingleJournalCardComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(SingleJournalCardComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
