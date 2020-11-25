import { Injectable } from '@angular/core';
import {HttpService} from './http.service';
import {Observable} from 'rxjs';
import {Message} from '../models/message.model';

@Injectable({
  providedIn: 'root'
})
export class MessageService extends HttpService {
  public getMessages(chatId: string, offset: number): Observable<Message[]> {
    const url = this.getUrl('messages/chat/' + chatId + '/' + offset);
    return this.http.get<Message[]>(url);
  }

  public insertMessage(message: Message): Observable<Message> {
    const url = this.getUrl('messages');
    return this.http.post<Message>(url, message);
  }
}
