import { Component, OnInit, Input } from '@angular/core';
import { RestService } from '../rest.service';
import { ActivatedRoute, Router } from '@angular/router';
@Component({
  selector: 'app-estudiante-add',
  templateUrl: './estudiante-add.component.html',
  styleUrls: ['./estudiante-add.component.css']
})
export class EstudianteAddComponent implements OnInit {

  @Input() estudianteData = { Nombre: '' };

  constructor(public rest:RestService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
  }

  addestudiante() {
    this.rest.addEstudiante(this.estudianteData).subscribe((result) => {
      this.router.navigate(['/estudiante']);
    }, (err) => {
      console.log(err);
    });
  }

}
