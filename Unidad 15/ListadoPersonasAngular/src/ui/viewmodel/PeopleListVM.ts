import { Injectable } from '@angular/core';
import { makeAutoObservable } from "mobx";
import { Persona } from "../../domain/entities/Persona";
import { PersonaUseCase } from '../../domain/usecases/PersonaUseCase';

@Injectable({ providedIn: 'root' })
export class PeopleListVM {

  private _personasList: Persona[] = [];
  private _personaSeleccionada?: Persona;

  constructor(private useCase: PersonaUseCase) {
    makeAutoObservable(this);
    this.cargarPersonas();
  }

  async cargarPersonas() {
    this._personasList = await this.useCase.getAllPersonas();
  }

  get personasList(): Persona[] {
    return this._personasList;
  }

  get personaSeleccionada(): Persona | undefined {
    return this._personaSeleccionada;
  }

  seleccionarPersona(idPersona: number): void {
    this._personaSeleccionada = this._personasList.find(p => p.ID === idPersona);
  }
}
