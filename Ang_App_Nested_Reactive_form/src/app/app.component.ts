import { Component } from '@angular/core';
import { FormGroup, FormArray, FormControl, Validators, FormBuilder, AbstractControl } from '@angular/forms';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Ang_App_Nested_Reactive_form';
  addressForm: FormGroup;

  address = [ ]


  ngOnInit() {
    this.addressForm = this.setUpForm(this.address);
    this.addressForm.patchValue(this.address);
    console.log(this.addressForm);
  }

  setUpForm(address: any[] ) {
    return new FormGroup({
      address: new FormArray(address.map((adr) => this.createAdr(adr)))
    });
  }

  get addressFormArray() {
    return (this.addressForm.get('address') as FormArray);
  }

  addNewAdr() {
    const newAdr = {
      name: '',
      City: '',
      Address: null
    }
    this.address.splice(0,0,newAdr);
    this.addressFormArray.insert(0, this.createAdr(newAdr))
  }

  createAdr(adr: any) {
    return new FormGroup({
      details: new FormGroup({
        name: new FormControl(adr.name, Validators.required),
        City: new FormControl(adr.City, Validators.required),
        Address: new FormControl(adr.Address, Validators.required)
      })
    })
  }
}
