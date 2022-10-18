import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-side-bar',
  templateUrl: './side-bar.component.html',
  styleUrls: ['./side-bar.component.css']
})
export class SideBarComponent implements OnInit {
  course: any = ["Angular","React","cSharp","ASP.NET","Java","Python","AWS","Azure"];
  show:boolean = false;

  showCourse(){
    this.show = !this.show;
  }
  constructor() { }

  ngOnInit(): void {
  }

}
