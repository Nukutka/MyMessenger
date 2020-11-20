import { Injectable } from '@angular/core';
import {HttpService} from './http.service';
import {Observable} from 'rxjs';
import {Message} from '../models/message.model';

@Injectable({
  providedIn: 'root'
})
export class MessageService extends HttpService {
  public getMessages(chatId: string): Observable<Message[]> {
    const url = this.getUrl('messages/chat/' + chatId);
    return this.http.get<Message[]>(url);
  }
}
