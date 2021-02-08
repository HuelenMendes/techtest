import { Component, Input, OnInit } from '@angular/core';
import { AppService } from './app.service';

@Component({
    selector: 'my-app',
    templateUrl: './app.component.html'
})

export class AppComponent implements OnInit {

    name1: string;
    name2: string;
    imageUrl1: string;
    imageUrl2: string;
    home: boolean = false;    
    constructor(private _data: AppService) { }
    ngOnInit() {
        this.home = true;           
        this.getRandomProducts();
    }

    getRandomProducts() {
        this._data.getRandomProducts().subscribe(data => {
            this.name1 = data.product1.name;
            this.name2 = data.product2.name;
            this.imageUrl1 = data.product1.imageUrl;
            this.imageUrl2 = data.product2.imageUrl;
        });
    }

    openList() {        
        this.home = false;    
    }   

    onBack() {
        this.home = true;
        this.getRandomProducts();
    }
}
