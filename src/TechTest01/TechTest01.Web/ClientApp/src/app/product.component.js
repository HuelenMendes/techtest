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
exports.ProductComponent = void 0;
var core_1 = require("@angular/core");
var app_service_1 = require("./app.service");
var ProductComponent = /** @class */ (function () {
    function ProductComponent(_data) {
        this._data = _data;
        this.back = new core_1.EventEmitter();
    }
    ProductComponent.prototype.ngOnInit = function () {
        this.getDetail();
    };
    ProductComponent.prototype.getDetail = function () {
        var _this = this;
        this._data.getProductDetail(this.slug).subscribe(function (data) {
            _this.prod = data;
            console.log(_this.prod.name + ' my-product detail ' + JSON.stringify(_this.prod));
        });
    };
    ProductComponent.prototype.goBack = function () {
        this.back.emit(false);
    };
    __decorate([
        core_1.Input('itemSlug'),
        __metadata("design:type", String)
    ], ProductComponent.prototype, "slug", void 0);
    __decorate([
        core_1.Output(),
        __metadata("design:type", Object)
    ], ProductComponent.prototype, "back", void 0);
    ProductComponent = __decorate([
        core_1.Component({
            selector: 'my-product',
            templateUrl: './product.component.html'
        }),
        __metadata("design:paramtypes", [app_service_1.AppService])
    ], ProductComponent);
    return ProductComponent;
}());
exports.ProductComponent = ProductComponent;
//# sourceMappingURL=product.component.js.map