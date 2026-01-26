import { Routes } from '@angular/router';
import { TablaPersonasComponent } from './components/tabla-personas/tabla-personas';
import { FormularioPersonaComponent } from './components/formulario-persona/formulario-persona';
import { ListadoPersonasComponent } from './components/listado-personas/listado-personas';
import { FormularioReactivoComponent } from './components/formulario-reactivo/formulario-reactivo';

export const routes: Routes = [
  { path: '', redirectTo: '/tabla', pathMatch: 'full' },
  { path: 'tabla', component: TablaPersonasComponent },
  { path: 'formulario', component: FormularioPersonaComponent },
  { path: 'listado', component: ListadoPersonasComponent },
  { path: 'formulario-reactivo', component: FormularioReactivoComponent }  // ← NUEVA RUTA
];