import { Component, OnInit, Input, EventEmitter, Output } from '@angular/core';
import Product from '../shared/Product';
import { AppService } from './app.service';


@Component({
    selector: 'my-product',
    templateUrl: './product.component.html'
})
export class ProductComponent implements OnInit {
    prod: Product;
    @Input('itemSlug') slug: string;
    @Output() back = new EventEmitter<boolean>();
    constructor(private _data: AppService) { }
    ngOnInit() {
        this.getDetail();
    }

    getDetail() {
        
        this._data.getProductDetail(this.slug).subscribe(data => {            
            this.prod = data;
            console.log(this.prod.name + ' my-product detail ' + JSON.stringify(this.prod));
        });
    }

    goBack() {        
        this.back.emit(false);
    }
}