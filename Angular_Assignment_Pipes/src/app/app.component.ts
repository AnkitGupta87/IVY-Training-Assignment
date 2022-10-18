import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Angular_Assignment_Pipes';
  str : string ="This is String";
  a:number = 0.257;
  b: number = 1.3495;
  today: number = Date.now();
  pi: number = 3.14159265359;
}
