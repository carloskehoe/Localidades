import { Component, OnInit } from '@angular/core';
import { LocationService } from '../../services/location.service';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.css']
})
export class HeaderComponent implements OnInit {

  constructor(private UserService: LocationService) {
    console.log(UserService.getPais())
   }

  ngOnInit(): void {
  }

}
