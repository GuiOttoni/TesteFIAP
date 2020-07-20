import { TestBed } from '@angular/core/testing';

import { ParceriaService } from './parceria.service';

describe('ParceriaServiceService', () => {
  let service: ParceriaService;

  beforeEach(() => {
    TestBed.configureTestingModule({});
    service = TestBed.inject(ParceriaService);
  });

  it('should be created', () => {
    expect(service).toBeTruthy();
  });
});
