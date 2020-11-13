import { Component, OnInit } from '@angular/core';

import { AuthService} from '../../services/auth.service';

@Component({
  selector: 'app-auth',
  templateUrl: './auth.component.html',
  styleUrls: ['./auth.component.scss']
})
export class AuthComponent implements OnInit {
  public login: string;
  public password: string;

  constructor(private authService: AuthService) { }

  ngOnInit(): void {
  }

  public auth(): void {
    this.authService.login(this.login, this.password);
  }

}
