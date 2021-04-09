import { Component, OnInit } from '@angular/core';
import { SocialAuthService  } from 'angularx-social-login';
import { SocialUser } from 'angularx-social-login';
import { GoogleLoginProvider } from 'angularx-social-login';
import {HttpClient} from '@angular/common/http';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {
  user: SocialUser | null; 
  readonly rootUrl = 'http://localhost:22609/api'

  constructor(private authService: SocialAuthService, private http : HttpClient) 
  { 
    this.user = null;
    this.authService.authState.subscribe((user: SocialUser) => {
    console.log(user);
    if (user) {
      this.http.post<any>(this.rootUrl+'/users/authenticate', { idToken: user.idToken }).subscribe((authToken: any) => {
      console.log(authToken);
       })		  
    }
    this.user = user;
	});
  }

  ngOnInit(): void {
   
  }

  signInWithGoogle(): void {
    this.authService.signIn(GoogleLoginProvider.PROVIDER_ID).then((x: any) => console.log(x));
  }

  signOut(): void {
    this.authService.signOut();
  }  
  

}
