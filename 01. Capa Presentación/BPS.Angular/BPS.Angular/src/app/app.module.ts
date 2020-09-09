import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';
import { FormsModule } from '@angular/forms';
import { AppComponent } from './app.component';
import { HttpClientModule } from '@angular/common/http';
import { RouterModule, Routes } from '@angular/router';
import { EstudianteComponent } from './estudiante/estudiante.component';
import { EstudianteAddComponent } from './estudiante-add/estudiante-add.component';
import { EstudianteDetailComponent } from './estudiante-detail/estudiante-detail.component';
import { EstudianteEditComponent } from './estudiante-edit/estudiante-edit.component';
import { ProfesorComponent } from './profesor/profesor.component';
import { ProfesorNuevoComponent } from './profesor-nuevo/profesor-nuevo.component';
import { NotasComponent } from './notas/notas.component';
import { NotasNuevoComponent } from './notas-nuevo/notas-nuevo.component';

const appRoutes: Routes = [
  {
    path: 'estudiante',
    component: EstudianteComponent,
    data: { title: 'Lista de Estudiantes' }
  },
  {
    path: 'estudiante-details/:id',
    component: EstudianteDetailComponent,
    data: { title: 'Product Details' }
  },
  {
    path: 'estudiante-add',
    component: EstudianteAddComponent,
    data: { title: 'Product Add' }
  },
  {
    path: 'product-edit/:id',
    component: EstudianteEditComponent,
    data: { title: 'Product Edit' }
  },
  { path: '',
    redirectTo: '/estudiante',
    pathMatch: 'full'
  }
];
@NgModule({
  declarations: [
    AppComponent,
    EstudianteComponent,
    EstudianteAddComponent,
    EstudianteDetailComponent,
    EstudianteEditComponent,
    ProfesorComponent,
    ProfesorNuevoComponent,
    NotasComponent,
    NotasNuevoComponent
  ],
  imports: [
    RouterModule.forRoot(appRoutes),
    FormsModule,
    BrowserModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
