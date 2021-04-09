import { NgModule } from '@angular/core';
import { RouterModule, Routes } from '@angular/router';
import { CheckOutComponent } from './check-out/check-out.component';
import { HomeComponent } from './home/home.component';
import { LoginComponent } from './login/login.component';
import { AuthGuardService } from './shared/auth-guard.service';
import { ShoppingCartComponent } from './shopping-cart/shopping-cart.component';

const routes: Routes = [
  { 
    path: '', 
    component: HomeComponent 
  },

  { 
    path: 'shopping-cart', 
    component: ShoppingCartComponent 
  },

  { 
    path: 'login', 
    component: LoginComponent 
  },

  { 
    path: 'check-out', 
    component: CheckOutComponent,
    canActivate : [AuthGuardService] 
  },
 
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
