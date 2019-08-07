import { Component, OnInit, ViewChild} from '@angular/core';

import {MatPaginator} from '@angular/material/paginator';
import {MatSort} from '@angular/material/sort';
import {MatTableDataSource} from '@angular/material/table';

import {ItemsService} from '../items.service'

export interface Item {
  ItemId: number;
  McItemId: string;
  McItemName: string;
  ItemQuanity: number;
  ItemDurability: number;
  ItemPrice: number;
}

@Component({
  selector: 'app-shop-main',
  templateUrl: './shop-main.component.html',
  styleUrls: ['./shop-main.component.scss']
})
export class ShopMainComponent implements OnInit {

  displayedColumns: string[] = ['Id', 'Przedmiot', 'Nazwa_przedmiotu', 'Liczba', 'Trwałość', 'Cena', 'Actions'];
  dataSource: MatTableDataSource<Item>;

  @ViewChild(MatPaginator, {static: true}) paginator: MatPaginator;
  @ViewChild(MatSort, {static: true}) sort: MatSort;

  Items: Item[];

  title = "McShop";
  

  constructor(private itemsService: ItemsService) { }

  loadItems(){
    this.itemsService.getAllItems().subscribe(data => {
      this.Items = <Item[]>data;

      this.dataSource = new MatTableDataSource(this.Items)

      this.dataSource.paginator = this.paginator;
      this.dataSource.sort = this.sort;

      console.log(this.Items);
    });
  }

  ngOnInit() {

    this.loadItems();

  }

  applyFilter(filterValue: string) {
    this.dataSource.filter = filterValue.trim().toLowerCase();

    if (this.dataSource.paginator) {
      this.dataSource.paginator.firstPage();
    }
  }

}
