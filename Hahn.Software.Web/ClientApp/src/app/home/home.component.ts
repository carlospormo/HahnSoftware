import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'home',
  templateUrl: './home.component.html'
})
export class HomeComponent {
  public books: Book[] = [];

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    http.get<Book[]>(baseUrl + 'Book').subscribe(result => {
      this.books = result;
    }, error => console.error(error));
  }
}

interface Book {
  id: number;
  name: string;
  author: string;
}
