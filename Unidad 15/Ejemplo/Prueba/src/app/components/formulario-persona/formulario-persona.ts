import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-formulario-persona',
  standalone: true,
  imports: [],
  templateUrl: './formulario-persona.html',
  styleUrl: './formulario-persona.css'
})
export class FormularioPersonaComponent {
  
  constructor(private router: Router) {}
  
  saludar(): void {
    alert('¡Hola! ¡Bienvenido!');
  }
  
  volverATabla(): void {
    this.router.navigate(['/tabla']);
  }
}