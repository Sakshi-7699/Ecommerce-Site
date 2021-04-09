import { Component, OnInit } from '@angular/core';
import { AuthService } from '../shared/auth.service';


@Component({
  selector: 'navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  
  constructor(public authservice: AuthService) {   
  }

  ngOnInit(): void {
  }

  signOut(): void {
   this.authservice.signOut();
  }  
  
}
