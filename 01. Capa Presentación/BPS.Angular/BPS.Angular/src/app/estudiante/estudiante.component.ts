import { Component, OnInit } from '@angular/core';
import { RestService } from '../rest.service';
import { ActivatedRoute, Router } from '@angular/router';

@Component({
  selector: 'app-estudiante',
  templateUrl: './estudiante.component.html',
  styleUrls: ['./estudiante.component.css']
})
export class EstudianteComponent implements OnInit {

  estudiantes:any = [];

  constructor(public rest:RestService, private route: ActivatedRoute, private router: Router) { }

  ngOnInit() {
    this.getestudiantes();
  }

  getestudiantes() {
    this.estudiantes = [];
    this.rest.getEstudiantes().subscribe((data => {
      console.log(data.Info);
      this.estudiantes = data.Info;
    }));
  }

  add() {
    this.router.navigate(['/estudiante-add']);
  }

  delete(id) {
    this.rest.deleteEstudiante(id)
      .subscribe(res => {
          this.getestudiantes();
        }, (err) => {
          console.log(err);
        }
      );
  }

}
