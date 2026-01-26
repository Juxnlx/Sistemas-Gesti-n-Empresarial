import { Component, OnInit } from '@angular/core';
import { CommonModule } from '@angular/common';
import { Persona } from '../../interfaces/persona';
import { PersonasService } from '../../services/personas';

@Component({
  selector: 'app-tabla-personas',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './tabla-personas.html',
  styleUrl: './tabla-personas.css'
})
export class TablaPersonasComponent implements OnInit {
  
  listadoPersonas: Persona[] = [];

  constructor(private personasServicio: PersonasService) { }

  ngOnInit(): void {
    this.obtenerPersonas();
  }

  obtenerPersonas(): void {
    this.personasServicio.getPersonas().subscribe({
      next: (response) => {
        this.listadoPersonas = response;
        console.log('Personas obtenidas:', this.listadoPersonas);
      },
      error: (error) => {
        console.error('Error:', error);
        alert("Ha ocurrido un error al obtener los datos del servidor");
      }
    });
  }
}