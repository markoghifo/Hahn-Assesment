import { ComponentFixture, TestBed } from '@angular/core/testing';

import { EditorsPageComponent } from './editors-page.component';

describe('EditorsPageComponent', () => {
  let component: EditorsPageComponent;
  let fixture: ComponentFixture<EditorsPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ EditorsPageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(EditorsPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
