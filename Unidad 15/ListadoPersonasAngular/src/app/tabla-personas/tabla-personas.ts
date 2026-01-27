import { Component, OnInit } from '@angular/core';
import { MatTableModule } from '@angular/material/table';
import { CommonModule } from '@angular/common';
import { Persona } from '../../domain/entities/Persona';
import { PersonaUseCase } from '../../domain/usecases/PersonaUseCase';

@Component({
  selector: 'app-tabla-personas',
  standalone: true,
  imports: [MatTableModule, CommonModule],
  templateUrl: './tabla-personas.html',
  styleUrl: './tabla-personas.css',
})
export class TablaPersonas implements OnInit {

  displayedColumns: string[] = ['id', 'nombre', 'apellidos', 'edad', 'telefono'];
  dataSource: Persona[] = [];

  constructor(private casoDeUso: PersonaUseCase) {}

  async ngOnInit(): Promise<void> {
    this.dataSource = await this.casoDeUso.getAllPersonas();
    console.log('Datos cargados desde la vista', this.dataSource);
  }
}
