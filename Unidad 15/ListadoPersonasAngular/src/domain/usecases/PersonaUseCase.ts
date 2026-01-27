import { Injectable } from '@angular/core';
import { PersonasRepository } from '../../data/repositories/PersonaRepository';
import { Persona } from '../entities/Persona';

@Injectable({
  providedIn: 'root'
})
export class PersonaUseCase {

  constructor(private personaRepository: PersonasRepository) {}

  async getAllPersonas(): Promise<Persona[]> {
    const personas = await this.personaRepository.getAllPersonas();
    return this.aplicarLogicaNegocio(personas);
  }

  private aplicarLogicaNegocio(personas: Persona[]): Persona[] {
    const hoy = new Date();
    const diaSemana = hoy.getDay();
    const esViernesOSabado = diaSemana === 5 || diaSemana === 6;

    if (!esViernesOSabado) return personas;

    return personas.filter(p => {
      if (!p.FechaNacimiento) return false;
      return this.calcularEdad(p.FechaNacimiento) >= 18;
    });
  }

  private calcularEdad(fechaNacimiento: Date): number {
    const hoy = new Date();
    let edad = hoy.getFullYear() - fechaNacimiento.getFullYear();
    const mes = hoy.getMonth() - fechaNacimiento.getMonth();
    if (mes < 0 || (mes === 0 && hoy.getDate() < fechaNacimiento.getDate())) {
      edad--;
    }
    return edad;
  }
}