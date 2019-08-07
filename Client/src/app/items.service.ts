import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ItemsService {

  constructor(private http: HttpClient) { }


  getAllItems(){
    return this.http.get("http://127.0.0.1:5001/api/items");
  }
}
