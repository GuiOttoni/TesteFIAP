import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ParceriaDialogComponent } from './parceria-dialog.component';

describe('ParceriaDialogComponent', () => {
  let component: ParceriaDialogComponent;
  let fixture: ComponentFixture<ParceriaDialogComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ParceriaDialogComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ParceriaDialogComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
