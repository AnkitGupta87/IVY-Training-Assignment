import { Component } from '@angular/core'; 

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.css']
})
export class AppComponent {
  title = 'Assignment-1';
  public cal = false;
  public allComp = false;

  public showCal(){
      this.cal = !this.cal;
  }
  public showAllComp(){
    this.allComp = !this.allComp;
  }
}
