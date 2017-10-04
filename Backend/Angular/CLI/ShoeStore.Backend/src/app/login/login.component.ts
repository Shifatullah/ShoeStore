import { Component, OnInit } from '@angular/core';
import { Http, Response, RequestOptions, RequestOptionsArgs, Headers } from '@angular/http';
declare var $: any;

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
        options.withCredentials = true;
        this._http.post('http://shoestoreusers-dotnet-webapi.azurewebsites.net/api/account/login', JSON.stringify({ loginName: user.value, password: password.value }), options)
            .subscribe((res: Response) => {
                //alert('login succeeded');
                $.cookie('.ASPXAUTH', res.text);
            });
        return false;

        //var http = new XMLHttpRequest();
        //var url = "http://shoestoreusers-dotnet-webapi.azurewebsites.net/api/account/login";
        //var params = JSON.stringify({ loginName: user.value, password: password.value });
        //http.open("POST", url, true);

        ////Send the proper header information along with the request
        //http.setRequestHeader("Content-type", "application/json");
        //http.withCredentials = true;
        //http.onreadystatechange = function () {//Call a function when the state changes.
        //    if (http.readyState == 4 && http.status == 200) {
        //        alert(http.responseText);
        //    }
        //}
        //http.send(params)
        //return false;
    }

}
