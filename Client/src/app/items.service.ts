import { Injectable } from '@angular/core';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class ItemsService {

  constructor(private http: HttpClient) { }


  getAllItems(){
    return this.http.get("http://192.168.88.197:5001/api/items");
  }
}
