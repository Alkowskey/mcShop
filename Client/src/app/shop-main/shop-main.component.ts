import { Component, OnInit } from '@angular/core';
import {ItemsService} from '../items.service'

@Component({
  selector: 'app-shop-main',
  templateUrl: './shop-main.component.html',
  styleUrls: ['./shop-main.component.scss']
})
export class ShopMainComponent implements OnInit {

  Items: Object;

  title = "McShop";
  

  constructor(private itemsService: ItemsService) { }

  loadItems(){
    this.itemsService.getAllItems().subscribe(data => {
      this.Items = data;
      console.log(data);
    });
  }

  ngOnInit() {

    this.loadItems();

  }

}
