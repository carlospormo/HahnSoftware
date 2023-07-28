import { Component, Inject } from '@angular/core';
import { HttpClient } from '@angular/common/http';

@Component({
  selector: 'home',
  templateUrl: './home.component.html'
})
export class HomeComponent {
  books: Book[] = [];
  book: any = {};
  http: HttpClient;
  baseUrl: string;

  constructor(http: HttpClient, @Inject('BASE_URL') baseUrl: string) {
    this.http = http;
    this.baseUrl = baseUrl;
    http.get<Book[]>(baseUrl + 'Book')
      .subscribe(result => {
        this.books = result;
      }, alert);
  }

  save() {
    if (this.book.id > 0) {
      this.http.put(this.baseUrl + 'Book', this.book)
        .subscribe(console.log, alert);
    } else {
      this.http.post(this.baseUrl + 'Book', this.book)
        .subscribe(console.log, alert);
    }
  }

  edit(book:Book) {
    this.book = book;
  }

  delete(book: Book) {
    this.http.delete(`${this.baseUrl}Book/${book.id}`)
      .subscribe(console.log, alert);
  }
}

interface Book {
  id: number;
  name: string;
  author: string;
}
