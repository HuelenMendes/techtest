import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
//import { Observable } from 'rxjs/Rx';
import "rxjs/add/operator/map";
import { Observable } from 'rxjs';
import HomeModel from '../shared/homeModel';
import ProductsModel from '../shared/ProductsModel';
import Product from '../shared/Product';


@Injectable()
export class AppService {
    

    constructor(private http: HttpClient) { }

    getRandomProducts(): Observable<HomeModel> {
        return this.http.get<HomeModel>('api/Default/GetRandom/');
    }     

    getProducts(): Observable<ProductsModel[]> {
        return this.http.get<ProductsModel[]>('api/Default/GetAll/');
    }

    getProductDetail(slug :string): Observable<Product> {
        return this.http.get<Product>('api/Default/GetDetail/?slug=' + slug);       
    }    
}