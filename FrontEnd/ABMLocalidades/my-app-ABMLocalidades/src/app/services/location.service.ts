import { Injectable } from '@angular/core';
import { HttpClient, HttpResponse } from '@angular/common/http';
import { IPais } from '../interfaces/pais';
import { Observable } from 'rxjs';
import { HttpHeaders } from '@angular/common/http';
import { IProvincia } from '../interfaces/provincia';
import { ICiudad } from '../interfaces/ciudad';


@Injectable({
  providedIn: 'root'
})
export class LocationService {
  private localidadesUrl = '/api/localidades/';
  constructor(private http: HttpClient) { }

  getPais(): Observable< IPais[]>{

    return this.http.get< IPais[]>(this.localidadesUrl + 'pais');
  }
  getProvincia(IdPais): Observable< IProvincia[]>{

    return this.http.get< IProvincia[]>(this.localidadesUrl + 'pais/' + IdPais + '/provincia');
  }
  getCiudad(IdProv: number): Observable< ICiudad[]>{

    return this.http.get< ICiudad[]>(this.localidadesUrl + 'provincia/'+ IdProv +' /ciudad');

  }

  saveCiudad(provinciaId:number, nombreCiudad:string): Observable<any> {
      let ciudad:ICiudad = {
        idProvincia: provinciaId,
        nombre:nombreCiudad
      }
      return this.http.post(this.localidadesUrl + 'ciudad', ciudad);
  }

}
