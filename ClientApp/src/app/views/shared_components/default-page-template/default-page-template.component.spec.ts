import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DefaultPageTemplateComponent } from './default-page-template.component';

describe('DefaultPageTemplateComponent', () => {
  let component: DefaultPageTemplateComponent;
  let fixture: ComponentFixture<DefaultPageTemplateComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DefaultPageTemplateComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(DefaultPageTemplateComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
