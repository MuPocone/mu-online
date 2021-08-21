import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ComponenteLateralComponent } from './componente-lateral.component';

describe('ComponenteLateralComponent', () => {
  let component: ComponenteLateralComponent;
  let fixture: ComponentFixture<ComponenteLateralComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ComponenteLateralComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ComponenteLateralComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
