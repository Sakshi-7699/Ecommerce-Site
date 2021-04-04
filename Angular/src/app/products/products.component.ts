import { Component, OnInit } from '@angular/core';
import { CategoryService } from '../shared/category.service';
import {HttpClient} from '@angular/common/http';

@Component({
  selector: 'products',
  templateUrl: './products.component.html',
  styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {
  categories:any=[]
  constructor(private service:CategoryService) { }

  ngOnInit(): void {
    this.getCategory();
  }

  getCategory(){
    this.service.getAll().subscribe( data=>{
        this.categories = data;
      });
  }
}
