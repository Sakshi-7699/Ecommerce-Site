import { Component, OnInit } from '@angular/core';
import { CategoryService } from '../shared/category.service';
import {HttpClient} from '@angular/common/http';
import { ProductService } from '../shared/product.service';
import { ActivatedRoute, RouteConfigLoadEnd } from '@angular/router';

@Component({
  selector: 'products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  categories:any=[]
  products:any=[]
  category:number;
  filterProducts:any=[]
  constructor(
    private route:ActivatedRoute,
    private categoryservice:CategoryService, 
    private productservice : ProductService) { 
    
     
  }

  ngOnInit(): void {
    this.setCatalog();
  }

  setCatalog(){
    this.categoryservice.getAll().subscribe( data=>{
        this.categories = data;
      });

      this.productservice.getAll().subscribe( data=>{
        this.products = data;

        this.route.queryParamMap.subscribe(params =>{
          this.category =Number(params.get('category'));
          
          this.filterProducts=(this.category)?
          this.products.filter(p => p.category_id===this.category):
          this.products;
  
          console.log(this.filterProducts)
        });
        
      });
      
       
  }
}
