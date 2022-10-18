import { Component } from '@angular/core';
import {NgModule} from "@angular/core";
import { CommonModule } from '@angular/common';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'matAssignment';
  showlogin : boolean = false;

  loginForm = new FormGroup({
    'username' : new FormControl(),
    'password' : new FormControl()
  })

  show(){
    this.showlogin = !this.showlogin
  }
}
