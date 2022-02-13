import { ComponentFixture, TestBed } from '@angular/core/testing';

import { JournalInformationPageComponent } from './journal-information-page.component';

describe('JournalInformationPageComponent', () => {
  let component: JournalInformationPageComponent;
  let fixture: ComponentFixture<JournalInformationPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ JournalInformationPageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(JournalInformationPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
