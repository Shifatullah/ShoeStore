import { Component, OnInit } from '@angular/core';
import { Http, Response } from '@angular/http';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor(private _http: Http) { }

  ngOnInit() {
  }

  public login(user: HTMLInputElement, password: HTMLInputElement): boolean {
      this._http
          .post('http://shoestoreusers-dotnet-webapi.azurewebsites.net/api/account/login', '{loginName: ' + user + ', password: ' + password + '}')
          .subscribe((res: Response) => {
              alert(res.json());
          });
      return false;     
  }

}
