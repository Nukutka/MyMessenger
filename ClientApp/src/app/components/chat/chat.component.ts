import { Component, OnInit, ViewChild, ElementRef } from '@angular/core';
import {Message} from '../../models/message.model';
import {MessageService} from '../../services/message.service';
import {Chat} from '../../models/chat.model';

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.scss']
})
export class ChatComponent implements OnInit {
  chat: Chat;
  messages: Message[];
  userId: string;

  constructor(private messageService: MessageService) { }

  ngOnInit(): void {
    this.userId = localStorage.getItem('userId');
  }

  public loadMessages(chat: Chat): void {
    this.chat = chat;

    this.messageService.getMessages(chat.id).subscribe(data => {
        this.messages = data;
      }
    );
  }

  public checkOwnerMessage(message: Message): boolean {
    return message.userId === this.userId;
  }

  public sendMessage(event): void {
    const messageBody = event.target.value;
    event.target.value = '';
    const message = new Message(messageBody, this.chat.id);
    this.messageService.insertMessage(message).subscribe(data => {
      this.messages.push(data);
  });
  }
}
