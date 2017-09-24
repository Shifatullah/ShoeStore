import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';
import { Http, Response } from '@angular/http';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
    _id: string;
    product: any;

    constructor(private _route: ActivatedRoute, private _router: Router, private _http: Http) {        
        this._route
          .params
          .subscribe(params => {              
              this._id = params['id'] || '';
              this.loadProduct();
          });
  }

  ngOnInit() {
  }

  loadProduct() {
      this._http.request('http://shoestoreproducts-dotnet-webapi.azurewebsites.net/api/products/' + this._id)
          .subscribe((res: Response) => {
              this.product = res.json();
          });
  }
}
