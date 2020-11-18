import {Injectable} from '@angular/core';
import {Router} from '@angular/router';

import {HttpService} from './http.service';
import {HttpClient} from '@angular/common/http';

@Injectable({
  providedIn: 'root'
})
export class AuthService extends HttpService{
  constructor(private router: Router, httpClient: HttpClient) {
    super(httpClient);
  }

  public login(email: string, password: string): void {
    const url = this.getUrl('auth/authenticate');
    this.http.post(url, {email, password})
      .subscribe((response: any) => {
        localStorage.setItem('token', response.token);
        this.router.navigate(['']);
      });
  }
}
