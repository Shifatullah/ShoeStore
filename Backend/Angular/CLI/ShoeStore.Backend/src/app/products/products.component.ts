import { Component, OnInit } from '@angular/core';
import { Http, Response, RequestOptions } from '@angular/http';

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
        let options = new RequestOptions();
        options.withCredentials = true;
        this._http.get('http://shoestoreproducts-dotnet-webapi.azurewebsites.net/api/products', options)
            .subscribe((res: Response) => {
                this.loading = false;                
                this.data = res.json();                
            });
    }

    ngOnInit() {

    }

}
