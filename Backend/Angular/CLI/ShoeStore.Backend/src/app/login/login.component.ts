import { Component, OnInit } from '@angular/core';
import { Http, Response, RequestOptions, RequestOptionsArgs, Headers } from '@angular/http';

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
        let headers = new Headers();
        headers.append('Content-Type', 'application/json');
        let options = new RequestOptions({ headers: headers });
        this._http.post('http://shoestoreusers-dotnet-webapi.azurewebsites.net/api/account/login', JSON.stringify({ loginName: user.value, password: password.value }), options)
            .subscribe((res: Response) => {
                alert('login succeeded');
            });
        return false;
    }

}
