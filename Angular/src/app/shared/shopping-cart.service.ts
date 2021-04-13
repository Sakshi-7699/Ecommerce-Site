import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cart } from '../model/Cart/cart.model';
import { Product } from '../model/Product/product.model';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class ShoppingCartService {

  readonly rootUrl = 'http://localhost:22609/api';
  
  constructor(private http : HttpClient) { }
  

   create(){     
     /*
      let cart = new Cart();
      cart.cart_id= result;     
      cart.product_id = product.product_id;
      cart.quantity =1;
      cart.user_id =0;
      
      const headers = new HttpHeaders().set('Content-Type ','application/json');
      return this.http.post<Cart>(this.rootUrl+'/cart',cart).subscribe(
        data =>{ console.log(console.error()) } );
    */
      let cart = new Cart();
      let  ob =  this.http.post<Cart>(this.rootUrl+'/cart',cart)
      return ob
    }

   

   async getOrCreateCart(product : Product){
    let cart_id= localStorage.getItem('cart_id');
    if (cart_id) return cart_id ; 
    
    let result = this.create()
    result.subscribe(val => localStorage.setItem('cart_id',String(val.cart_id)));
    
    
  }
   
 
  async addToCart(product : any){
    let cartId = await this.getOrCreateCart(product);    
    
  }

  

}
