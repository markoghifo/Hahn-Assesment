import { ComponentFixture, TestBed } from '@angular/core/testing';

import { CodeOfEthicsPageComponent } from './code-of-ethics-page.component';

describe('CodeOfEthicsPageComponent', () => {
  let component: CodeOfEthicsPageComponent;
  let fixture: ComponentFixture<CodeOfEthicsPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ CodeOfEthicsPageComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(CodeOfEthicsPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
