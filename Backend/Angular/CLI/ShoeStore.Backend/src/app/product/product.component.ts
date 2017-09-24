import { Component, OnInit } from '@angular/core';
import { Router, ActivatedRoute } from '@angular/router';

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.css']
})
export class ProductComponent implements OnInit {
    _id: string;

    constructor(private _route: ActivatedRoute, private _router: Router) {
        debugger;
        this._route
          .params
          .subscribe(params => {
              debugger;
              this._id = params['id'] || '';
              alert(this._id);
          });
  }

  ngOnInit() {
  }

}
