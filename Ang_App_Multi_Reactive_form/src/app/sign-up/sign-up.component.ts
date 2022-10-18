import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';


@Component({
  selector: 'app-sign-up',
  templateUrl: './sign-up.component.html',
  styleUrls: ['./sign-up.component.css']
})
export class SignUpComponent implements OnInit {

  ReactiveForm = new FormGroup({
    'email': new FormControl(),
    'Password': new FormControl(),
    'Re-Password': new FormControl()
  })

  reset(){
    this.ReactiveForm.reset();
  }

  OnSignUp(){
    console.log(this.ReactiveForm.value);
    this.ReactiveForm.reset();
  }
  constructor() { }

  ngOnInit(): void {
  }

}
