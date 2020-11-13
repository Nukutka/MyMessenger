import {Injectable} from '@angular/core';
import {Router} from '@angular/router';

import {HttpService} from './http.service';

@Injectable({
  providedIn: 'root'
})
export class AuthService {
  constructor(private router: Router, private httpService: HttpService) {
  }

  public login(login: string, password: string): void {
    this.httpService.auth(login, password)
      .subscribe((response: any) => {
        localStorage.setItem('token', response.token);
        this.router.navigate(['']);
      });
  }
}
