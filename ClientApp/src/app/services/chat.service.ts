import { Injectable } from '@angular/core';
import {HttpService} from './http.service';
import {Observable} from 'rxjs';
import {Chat} from '../models/chat.model';

@Injectable({
  providedIn: 'root'
})
export class ChatService extends HttpService {
  public getChats(): Observable<Chat[]> {
    const url = this.getUrl('chats');
    return this.http.get<Chat[]>(url);
  }
}
