import { Injectable } from '@angular/core';
import {HttpClient, HttpHeaders, HttpParams} from '@angular/common/http';
import {Observable} from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class HttpService {
  private api: string;

  constructor(protected http: HttpClient) {
    this.api = 'http://localhost:8000/api/';
  }

  protected getUrl(endpoint: string): string {
    return this.api + endpoint;
  }
}
