import { Component } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-listado-personas',
  standalone: true,
  imports: [],
  templateUrl: './listado-personas.component.html',
  styleUrl: './listado-personas.component.css'
})
export class ListadoPersonasComponent {
  
  constructor(private router: Router) {}
  
  volverATabla(): void {
    this.router.navigate(['/tabla']);
  }
  
}