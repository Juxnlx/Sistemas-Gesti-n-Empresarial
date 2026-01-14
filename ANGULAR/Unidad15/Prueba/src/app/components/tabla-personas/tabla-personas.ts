import { Component } from '@angular/core';
import { Router, RouterLink } from '@angular/router';

@Component({
  selector: 'app-tabla-personas',
  standalone: true,
  imports: [RouterLink],
  templateUrl: './tabla-personas.component.html',
  styleUrl: './tabla-personas.component.css'
})
export class TablaPersonasComponent {
  
  constructor(private router: Router) {}
  
  abrirListado(): void {
    this.router.navigate(['/listado']);
  }
  
}