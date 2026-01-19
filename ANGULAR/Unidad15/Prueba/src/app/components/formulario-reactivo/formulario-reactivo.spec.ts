import { ComponentFixture, TestBed } from '@angular/core/testing';
import { FormularioReactivoComponent } from './formulario-reactivo';
import { provideRouter } from '@angular/router';

describe('FormularioReactivoComponent', () => {
  let component: FormularioReactivoComponent;
  let fixture: ComponentFixture<FormularioReactivoComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [FormularioReactivoComponent],
      providers: [provideRouter([])]
    })
    .compileComponents();

    fixture = TestBed.createComponent(FormularioReactivoComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});