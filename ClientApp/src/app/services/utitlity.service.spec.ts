import { TestBed } from '@angular/core/testing';

import { UtilityService } from './utitlity.service';

describe('UtitlityService', () => {
  let service: UtilityService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(UtilityService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
