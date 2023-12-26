import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent implements OnInit {
  title = 'Dating App';
  public users :User[] | undefined;
  constructor(private http:HttpClient){}
  ngOnInit(): void {
    this.http.get('https://localhost:5001/api/users').subscribe({
      next:(Response:any)=> this.users = Response,
      error:error => console.log(error),
      complete:()=> console.log('Request is completed')
    });
  }
}
export class User{
  id:number | undefined;
  userName:string | undefined;
}
