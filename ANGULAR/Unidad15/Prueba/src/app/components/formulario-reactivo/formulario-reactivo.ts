import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl, Validators, ReactiveFormsModule } from '@angular/forms';
import { CommonModule } from '@angular/common';
import { Router } from '@angular/router';

@Component({
  selector: 'app-formulario-reactivo',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './formulario-reactivo.html',
  styleUrl: './formulario-reactivo.css'
})
export class FormularioReactivoComponent implements OnInit {
  
  formulario: FormGroup;

  constructor(private router: Router) {
    // Inicializar el formulario vacío
    this.formulario = new FormGroup({});
  }

  ngOnInit(): void {
    // Crear el formulario con validaciones.
    this.formulario = new FormGroup({
      nombre: new FormControl('', [
        Validators.required,           
        Validators.minLength(3)        
      ]),
      apellidos: new FormControl('', [
        Validators.required,           
        Validators.minLength(3)        
      ])
    });
  }

  saluda(): void {
    if (this.formulario.valid) {
      const nombre = this.formulario.controls['nombre'].value;
      const apellidos = this.formulario.controls['apellidos'].value;
      alert(`Hola ${nombre} ${apellidos}`);
    }
  }

  volverATabla(): void {
    this.router.navigate(['/tabla']);
  }
}