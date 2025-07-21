import { HttpClient } from '@angular/common/http';
import { Component, inject, OnInit, signal } from '@angular/core';

@Component({
  selector: 'app-root',
  imports: [],
  templateUrl: './app.html',
  styleUrl: './app.css'
})
export class App implements OnInit{
  protected readonly title = 'client';
  private http = inject(HttpClient);

    ngOnInit(): void {
    this.http.get("https://localhost:5001/api/User").subscribe({
      next : response => console.log(response),
      error : error => console.error(error),
      complete : () => console.log("completed http request")
      
    }
      
    )
  }

}
