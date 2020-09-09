import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NotasNuevoComponent } from './notas-nuevo.component';

describe('NotasNuevoComponent', () => {
  let component: NotasNuevoComponent;
  let fixture: ComponentFixture<NotasNuevoComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NotasNuevoComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NotasNuevoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
