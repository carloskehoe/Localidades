import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';


import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HeaderComponent } from './components/header/header.component';
import { LocationsComponent } from './components/locations/locations.component';
import { LocationService } from './services/location.service';
import { HttpClientModule } from '@angular/common/http';
import { FormsModule }   from '@angular/forms';


@NgModule({
  declarations: [
    AppComponent,
    HeaderComponent,
    LocationsComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule,
    FormsModule
  ],
  providers: [LocationService],
  bootstrap: [AppComponent]
})
export class AppModule { }
