import { Component, OnInit, Input } from '@angular/core';
import { FormGroup, FormControl, FormArray } from '@angular/forms';

@Component({
  selector: 'app-detail-fields',
  templateUrl: './detail-fields.component.html',
  styleUrls: ['./detail-fields.component.css']
})
export class DetailFieldsComponent implements OnInit {

  @Input() form: FormGroup;
  @Input() adr: any;
  @Input() adrIndex: number;
  constructor() { }

  ngOnInit(): void {
  }

}
