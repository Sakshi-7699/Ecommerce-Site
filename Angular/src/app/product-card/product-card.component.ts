import { Component, Input, OnInit } from '@angular/core';
import { Cart } from '../model/Cart/cart.model';
import { Product } from '../model/Product/product.model';
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

  addToCart(product : Product){    
    this.cartservice.addToCart(product);
  }

  getQuantity(product : Product){
    this.cartservice.getQuantity(product).subscribe(
       val => {console.log(val)}
    )
    return 0;
  }

  

}
