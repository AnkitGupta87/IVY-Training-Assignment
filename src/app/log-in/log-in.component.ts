import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';

@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.css']
})
export class LogInComponent implements OnInit {

  constructor() { }

  ReactiveForm = new FormGroup({
    'email': new FormControl(),
    'Password': new FormControl(),
    'checkBox': new FormControl()
  })
  onSubmit(){
    console.log(this.ReactiveForm.value);
    this.ReactiveForm.reset();
  }
  OnReset(){
    this.ReactiveForm.reset();
  }
  ngOnInit(): void {
  }

}
