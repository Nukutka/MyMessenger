import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders, HttpParams} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  api: string;

  constructor(private http: HttpClient) {
    this.api = 'http://localhost:8000/api/';
  }

  private getUrl(endpoint: string): string {
    return this.api + endpoint;
  }

  public auth(login: string, password: string): Observable<any> {
    const url = this.getUrl('auth/authenticate');
    return this.http.post(url, {login, password});
  }
}
