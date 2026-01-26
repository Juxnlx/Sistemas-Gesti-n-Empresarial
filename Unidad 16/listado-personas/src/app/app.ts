import { Component } from '@angular/core';
import { TablaPersonasComponent } from './components/tabla-personas/tabla-personas';

@Component({
  selector: 'app-root',
  standalone: true,
  imports: [TablaPersonasComponent],  // ← Quita RouterOutlet
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class AppComponent {
  title = 'listado-personas';
}