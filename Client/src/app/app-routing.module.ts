import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import {ShopMainComponent} from './shop-main/shop-main.component'

const routes: Routes = [
  {path: "", component: ShopMainComponent}
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
