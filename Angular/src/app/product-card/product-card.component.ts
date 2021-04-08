import { Component, Input, OnInit } from '@angular/core';
import { Cart } from '../model/Cart/cart.model';
import { ShoppingCartService } from '../shared/shopping-cart.service';

@Component({
  selector: 'product-card',
  templateUrl: './product-card.component.html',
  styleUrls: ['./product-card.component.css']
})
export class ProductCardComponent  {
  @Input('product') product:any=[]

  constructor(private cartservice : ShoppingCartService) { }

  ngOnInit(): void {
  }

  addToCart(product : any){
    console.log('Product card component addtocart called');
    this.cartservice.addToCart(product);
  }

  getQuantity(){
    return 0;
  }

}
