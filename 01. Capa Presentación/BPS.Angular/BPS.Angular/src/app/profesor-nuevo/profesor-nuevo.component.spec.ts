import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ProfesorNuevoComponent } from './profesor-nuevo.component';

describe('ProfesorNuevoComponent', () => {
  let component: ProfesorNuevoComponent;
  let fixture: ComponentFixture<ProfesorNuevoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ProfesorNuevoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ProfesorNuevoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
