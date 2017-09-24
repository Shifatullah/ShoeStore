import { Component, OnInit } from '@angular/core';
import { Http, Response } from '@angular/http';

@Component({
    selector: 'app-products',
    templateUrl: './products.component.html',
    styleUrls: ['./products.component.css']
})
export class ProductsComponent implements OnInit {

    data: JSON;
    loading: boolean;
    _http: Http;

    constructor(private http: Http) {
        this._http = http;
        this.loading = false;
        this.fetchProducts();
    }

    public fetchProducts(): void {
        this.loading = true;        
        this._http.request('http://shoestoreproducts-dotnet-webapi.azurewebsites.net/api/products')
            .subscribe((res: Response) => {
                this.loading = false;                
                this.data = res.json();                
            });
    }

    ngOnInit() {

    }

}
