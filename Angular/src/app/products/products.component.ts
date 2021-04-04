import { Component, OnInit } from '@angular/core';
import { CategoryService } from '../shared/category.service';
import {HttpClient} from '@angular/common/http';
import { ProductService } from '../shared/product.service';

@Component({
  selector: 'products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  categories:any=[]
  products:any=[]
  constructor(private categoryservice:CategoryService, private productservice : ProductService) { }

  ngOnInit(): void {
    this.getCategory();
  }

  getCategory(){
    this.categoryservice.getAll().subscribe( data=>{
        this.categories = data;
      });

      this.productservice.getAll().subscribe( data=>{
        this.products = data;
      });
    
  }
}
