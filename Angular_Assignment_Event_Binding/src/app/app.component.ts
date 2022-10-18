import { Component } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Angular_Assignment_Event_Binding';
  eventType1: any;
  eventType2: any;
  showClick: boolean = false;
  showHover: boolean = false;
  greet($event: any) {
    console.log($event.type);
    this.eventType1 = $event.type;
    this.showClick = true;
  }
  greetHover($event: any) {
    console.log($event.type);
    this.eventType2 = $event.type;
    this.showHover = !this.showHover;


  }
}
