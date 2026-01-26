import { Injectable, inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Observable } from 'rxjs';
import { Persona } from '../interfaces/persona';

@Injectable({
  providedIn: 'root'
})
export class PersonasService {

  // URL de la API
  urlWebAPI = 'https://juanluis-g9hvdhc7azdvgphc.spaincentral-01.azurewebsites.net/api/persona';

  // Inyectamos HttpClient
  http = inject(HttpClient);

  constructor() { }

  // Método para obtener todas las personas
  getPersonas(): Observable<Persona[]> {
    return this.http.get<Persona[]>(this.urlWebAPI);
  }
}