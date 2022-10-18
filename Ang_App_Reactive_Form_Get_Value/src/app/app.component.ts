import { Component } from '@angular/core';
import { FormControl, FormGroup } from '@angular/forms';  

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Ques2';
  name = new FormControl('');  
  ReactiveForm = new FormGroup({
      'username' : new FormControl(null),
      'email': new FormControl(null),
      'course': new FormControl(null),
      'gender': new FormControl(null)
  })
  OnSubmit(){
    console.log(this.ReactiveForm.value);
  }
}
