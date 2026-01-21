import { CommonModule } from '@angular/common';
import { Component, OnInit } from '@angular/core';
import { Persona } from '../../../domain/entities/Persona';
import { PersonaUseCase } from '../../..//domain/usecases/PersonaUseCase';

@Component({
  selector: 'app-people-list',
  standalone: true,
  imports: [CommonModule],
  templateUrl: './people-list.component.html',
  styleUrl: './people-list.component.css'
})
export class PeopleListComponent implements OnInit {

  personasList: Persona[] = [];
  personaSeleccionada: Persona | null = null;
  isLoading: boolean = true;
  errorMessage: string = '';

  constructor(private personaUseCase: PersonaUseCase) {}

  ngOnInit(): void {
    this.cargarPersonas();
  }

  cargarPersonas(): void {
    this.isLoading = true;
    this.errorMessage = '';

    try {
      this.personasList = this.personaUseCase.getPersonas();
      this.isLoading = false;
      console.log('Personas cargadas:', this.personasList);
    } catch (error) {
      this.errorMessage = 'Error al cargar las personas';
      this.isLoading = false;
      console.error('Error:', error);
    }
  }

  seleccionarPersona(persona: Persona): void {
    this.personaSeleccionada = persona;
  }

  estaSeleccionada(persona: Persona): boolean {
    return this.personaSeleccionada?.id === persona.id;
  }

  getInicial(persona: Persona): string {
    return persona.nombre?.charAt(0)?.toUpperCase() || '?';
  }

  eliminarPersona(id: number): void {
    if (confirm('¿Estás seguro de eliminar esta persona?')) {
      try {
        this.personaUseCase.deletePersona(id);
        this.cargarPersonas();
        
        if (this.personaSeleccionada?.id === id) {
          this.personaSeleccionada = null;
        }
      } catch (error) {
        console.error('Error al eliminar:', error);
        alert('Error al eliminar la persona');
      }
    }
  }
}