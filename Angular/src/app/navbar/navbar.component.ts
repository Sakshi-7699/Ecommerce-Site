import { Component, OnInit } from '@angular/core';
import { SocialAuthService  } from 'angularx-social-login';
import { SocialUser } from 'angularx-social-login';
import { GoogleLoginProvider } from 'angularx-social-login';


@Component({
  selector: 'navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.css']
})
export class NavbarComponent implements OnInit {
  user : SocialUser;

  constructor(private authService: SocialAuthService) { 
    authService.authState.subscribe(user=>{
      this.user = user;
    })
  }

  ngOnInit(): void {
  }

  signOut(): void {
    this.authService.signOut();
  }  
  
}
