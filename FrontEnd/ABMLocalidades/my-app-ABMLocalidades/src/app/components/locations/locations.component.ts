import { Component, OnInit } from '@angular/core';
import { LocationService } from '../../services/location.service';
import { IPais } from '../../interfaces/pais';
import { IProvincia } from '../../interfaces/provincia';
import { ICiudad } from '../../interfaces/ciudad';

@Component({
  selector: 'app-locations',
  templateUrl: './locations.component.html',
  styleUrls: ['./locations.component.css']
})
export class LocationsComponent implements OnInit {

  constructor(private userService: LocationService) { }
  paises: IPais[];
  provincias: IProvincia[];
  ciudades: ICiudad[];

  provinciaId:number;  

  ngOnInit(): void {
    this.getPaises();
  }

  getPaises() {

    this.userService.getPais().subscribe((data : IPais[])=> {
      this.paises = data;
      console.log(this.paises);

    })
  }

onPaisChange(nombrePais: any){
  debugger;
  let pais = this.paises.find(p => p.nombre == nombrePais);
  this.getProvincias(pais.id);
}


  getProvincias(IdPais : number) {

    this.userService.getProvincia(IdPais).subscribe((data : IProvincia[])=> {
      this.provincias = data;
      console.log(this.provincias);
    })
  }
  onProvinciaChange(nombreProvincia: string){
    debugger;
    let  provinciaSeleccionada = this.provincias.find(i => i.nombre == nombreProvincia);
    this.provinciaId = provinciaSeleccionada.id;
    //this.getCiudad(provinciaSeleccionada.idProvincia);
    
  }

  register(myform){
    debugger
    this.userService.saveCiudad(this.provinciaId, myform.value.ciudad)
    .subscribe((response: any)=> {
      console.log(response)
    });
   

  }

  // getCiudad(IdProvincia: number) {

  //   this.userService.getCiudad(IdProvincia).subscribe((data : ICiudad[])=> {
  //     this.ciudades = data;
  //     console.log(this.ciudades);
  //   })
  // }
  // onCiudadChange(nombreCiudad: string){
  //   debugger;
  //   let ciudad = this.ciudades.find(p => p.nombreLocalidad == nombreCiudad);
  //   this.getCiudad (ciudad.dProvincia);
  // }
 

}
