import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.css']
})
export class LoginComponent implements OnInit {

  constructor() { }

  ngOnInit() {
  }

  public login(user: HTMLInputElement, password: HTMLInputElement): boolean {
      console.log(`Login with user: ${user.value} and password: ${password.value}`);
      return false;     
  }

}
