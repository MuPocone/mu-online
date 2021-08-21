import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { CastleSiegeComponent } from './castle-siege.component';

describe('CastleSiegeComponent', () => {
  let component: CastleSiegeComponent;
  let fixture: ComponentFixture<CastleSiegeComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ CastleSiegeComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(CastleSiegeComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
