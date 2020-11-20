import { Component, OnInit } from '@angular/core';
import {Message} from '../../models/message.model';
import {MessageService} from '../../services/message.service';
import {Chat} from '../../models/chat.model';

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.scss']
})
export class ChatComponent implements OnInit {
  chatName: string;
  messages: Message[];
  userId: string;

  constructor(private messageService: MessageService) { }

  ngOnInit(): void {
    this.userId = localStorage.getItem('userId');
  }

  public loadMessages(chat: Chat): void {
    this.chatName = chat.name;

    this.messageService.getMessages(chat.id).subscribe(
      data => this.messages = data
    );
  }

  public checkOwnerMessage(message: Message): boolean {
    return message.userId === this.userId;
  }
}
