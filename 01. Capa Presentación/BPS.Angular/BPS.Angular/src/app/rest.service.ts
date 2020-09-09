import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders, HttpErrorResponse } from '@angular/common/http';
import { Observable, of } from 'rxjs';
import { map, catchError, tap } from 'rxjs/operators';

const endpoint = 'http://bpsapi.cmceledon.com/api/';
const httpOptions = {
  headers: new HttpHeaders({
    'Content-Type':  'application/json'
  })
};

@Injectable({
  providedIn: 'root'
})
export class RestService {

  constructor(private http: HttpClient) {}

  private extractData(res: Response) {
    let body = res;
    return body || { };
  }

  getEstudiantes(): Observable<any> {
    return this.http.get(endpoint + 'Estudiante/ConsultarEstudiantes').pipe(
      map(this.extractData));
  }

  getEstudiante(id): Observable<any> {
    return this.http.get(endpoint + 'Estudiante/ConsultarEstudianteId?idEstudiante=' + id).pipe(
      map(this.extractData));
  }

  addEstudiante (Estudiante): Observable<any> {
    console.log(Estudiante);
    return this.http.post<any>(endpoint + 'Estudiante/InsertarEstudiante', JSON.stringify(Estudiante), httpOptions).pipe(
      tap((Estudiante) => console.log(`added Estudiante w/ id=${Estudiante.idEstudiante}`)),
      catchError(this.handleError<any>('addEstudiante'))
    );
  }

  updateEstudiante (id, Estudiante): Observable<any> {
    return this.http.post(endpoint + 'Estudiante/' + id, JSON.stringify(Estudiante), httpOptions).pipe(
      tap(_ => console.log(`updated Estudiante id=${id}`)),
      catchError(this.handleError<any>('updateEstudiante'))
    );
  }

  deleteEstudiante (id): Observable<any> {
    return this.http.post<any>(endpoint + 'Estudiante/EliminarEstudiante?idEstudiante=' + id, httpOptions).pipe(
      tap(_ => console.log(`deleted Estudiante id=${id}`)),
      catchError(this.handleError<any>('deleteEstudiante'))
    );
  }

  private handleError<T> (operation = 'operation', result?: T) {
    return (error: any): Observable<T> => {

      // TODO: send the error to remote logging infrastructure
      console.error(error); // log to console instead

      // TODO: better job of transforming error for user consumption
      console.log(`${operation} failed: ${error.message}`);

      // Let the app keep running by returning an empty result.
      return of(result as T);
    };
  }
}