import { Component } from '@angular/core';

@Component({
  selector: 'app-formulario-persona',
  standalone: true,
  imports: [],
  templateUrl: './formulario-persona.html',
  styleUrl: './formulario-persona.css',
})
export class FormularioPersona {
  saludar(): void {
    alert('¡Hola! ¡Bienvenido!');
  }
}
