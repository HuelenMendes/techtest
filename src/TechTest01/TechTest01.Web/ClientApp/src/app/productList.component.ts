import { Component, OnInit, EventEmitter, Output } from '@angular/core';
import ProductModel from '../shared/ProductsModel';
import { AppService } from './app.service';

@Component({
    selector: 'my-productList',
    templateUrl: './productList.component.html'
})

export class ProductListComponent implements OnInit {
    lst: ProductModel[];
    detail: boolean = false;
    slug: string = "";
    @Output() back = new EventEmitter<boolean>();

    constructor(private _data: AppService) { }
    ngOnInit() {
        this.detail = false;        
        this.getListProducts();
    }

    getListProducts() {
        this._data.getProducts().subscribe(data => {
            this.lst = data;          
        });
    }

    openDetail(slug: string) {
        this.detail = true;
        this.slug = slug;
    }

    goBack() {
        this.back.emit(false);
    }

    onBack() {        
        this.slug = "";
        this.detail = false;
        this.getListProducts();
    }
}