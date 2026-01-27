import { Injectable } from '@angular/core';
import type { IRepositoryPersonas } from "../../domain/interfaces/repositories/IRepositoryPersonas";
import { Persona } from "../../domain/entities/Persona";
import { BaseAPI } from "../datasource/BaseAPI";

@Injectable({
  providedIn: 'root'
})
export class PersonasRepository implements IRepositoryPersonas {

  constructor(private dataSource: BaseAPI) {}

  async getAllPersonas(): Promise<Persona[]> {
    return await this.dataSource.fetchPersonaList();
  }
}
