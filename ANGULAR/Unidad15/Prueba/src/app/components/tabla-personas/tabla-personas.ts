import { Component } from '@angular/core';
import { Router, RouterLink } from '@angular/router';
import { CommonModule } from '@angular/common';
import { FormsModule } from '@angular/forms';

// Importar módulos de Angular Material
import { MatProgressSpinnerModule } from '@angular/material/progress-spinner';
import { MatRadioModule } from '@angular/material/radio';
import { MatSliderModule } from '@angular/material/slider';
import { MatCardModule } from '@angular/material/card';
import { MatButtonModule } from '@angular/material/button';
import { MatCheckboxModule } from '@angular/material/checkbox';
import { MatChipsModule } from '@angular/material/chips';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-tabla-personas',
  standalone: true,
  imports: [
    RouterLink,
    CommonModule,
    FormsModule,
    // Módulos de Material
    MatProgressSpinnerModule,
    MatRadioModule,
    MatSliderModule,
    MatCardModule,
    MatButtonModule,
    MatCheckboxModule,
    MatChipsModule,
    MatIconModule
  ],
  templateUrl: './tabla-personas.html',
  styleUrl: './tabla-personas.css'
})
export class TablaPersonasComponent {
  
  // Variables para los componentes de Material
  selectedColor: string = 'primary';
  sliderValue: number = 50;
  isLoading: boolean = true;
  
  constructor(private router: Router) {
    // Simular carga de datos (para el spinner)
    setTimeout(() => {
      this.isLoading = false;
    }, 2000);
  }
  
  abrirListado(): void {
    this.router.navigate(['/listado']);
  }
  
  onSliderChange(value: number): void {
    this.sliderValue = value;
    console.log('Valor del slider:', value);
  }
  
  onColorChange(color: string): void {
    this.selectedColor = color;
    console.log('Color seleccionado:', color);
  }
}