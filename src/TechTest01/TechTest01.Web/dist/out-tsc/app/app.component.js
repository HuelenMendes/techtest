"use strict";
var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
var __metadata = (this && this.__metadata) || function (k, v) {
    if (typeof Reflect === "object" && typeof Reflect.metadata === "function") return Reflect.metadata(k, v);
};
Object.defineProperty(exports, "__esModule", { value: true });
exports.AppComponent = void 0;
var core_1 = require("@angular/core");
var app_service_1 = require("./app.service");
var AppComponent = /** @class */ (function () {
    function AppComponent(_data) {
        this._data = _data;
    }
    AppComponent.prototype.ngOnInit = function () {
        this.getRandomProducts();
    };
    AppComponent.prototype.getRandomProducts = function () {
        this._data.getRandomProducts();
        //.then(
        //    (result: any) => {
        //        var res = result;
        //    });
        this.name1 = 'Welcome 1';
        this.name2 = 'Welcome 2';
        this.ImageUrl1 = "https://leejeans.com.au/dw/image/v2/BDFS_PRD/on/demandware.static/-/Sites-leejeans-master-catalog/default/dw9d2b971c/images/L_652098_/L_652098_AM2_3.jpg?sw=600&sh=600";
        this.ImageUrl2 = "https://leejeans.com.au/dw/image/v2/BDFS_PRD/on/demandware.static/-/Sites-leejeans-master-catalog/default/dw9d2b971c/images/L_652098_/L_652098_AM2_3.jpg?sw=600&sh=600";
    };
    AppComponent = __decorate([
        core_1.Component({
            selector: 'my-app',
            templateUrl: './app.component.html'
        }),
        __metadata("design:paramtypes", [app_service_1.AppService])
    ], AppComponent);
    return AppComponent;
}());
exports.AppComponent = AppComponent;
//# sourceMappingURL=app.component.js.map