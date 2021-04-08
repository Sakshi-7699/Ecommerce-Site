import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import { Observable } from 'rxjs';
import { Cart } from '../model/Cart/cart.model';
import { Product } from '../model/Product/product.model';

@Injectable({
  providedIn: 'root'
})
export class ShoppingCartService {

  readonly rootUrl = 'http://localhost:22609/api'
  constructor(private http : HttpClient) { }
  counter_cartid = 14

   create(product: Product){
      
      let cart = new Cart();
      cart.cart_id= this.counter_cartid+1;
      this.counter_cartid+=1;
      cart.product_id = product.product_id;
      cart.quantity =1;
      cart.user_id =0;
      console.log(cart);
      const headers = new HttpHeaders().set('Content-Type ','application/json');
      return this.http.post<Cart>(this.rootUrl+'/cart',cart).subscribe(
        data =>{
          console.log(console.error()
          )
        }
      );
    }

   getAll():Observable<ArrayBuffer>{
    return this.http.get<ArrayBuffer>(this.rootUrl+'/cart')
  }

   async getOrCreateCart(product : Product){
    let cart_id= localStorage.getItem('cart_id');
    if (cart_id) return cart_id

    let result =  this.create(product);
    console.log('result : '+ result);
    
    //localStorage.setItem('cart_id',result);
    
    
  }

 
  async addToCart(product : any){
    let cartId = await this.getOrCreateCart(product);
    //this.create(product);
    
  }

}
