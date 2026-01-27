import type { Persona } from "../../entities/Persona";

export interface IRepositoryPersonas {
  getAllPersonas(): Promise<Persona[]>;
}