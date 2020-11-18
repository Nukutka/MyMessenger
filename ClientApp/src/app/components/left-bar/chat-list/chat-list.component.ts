import { Component, OnInit } from '@angular/core';
import {Chat} from '../../../models/chat.model';
import {ChatService} from '../../../services/chat.service';

@Component({
  selector: 'app-chat-list',
  templateUrl: './chat-list.component.html',
  styleUrls: ['./chat-list.component.scss']
})
export class ChatListComponent implements OnInit {
  chats: Chat[];

  constructor(private chatService: ChatService) { }

  ngOnInit(): void {
    this.chatService.getChats().subscribe(
      data => this.chats = data
    );
  }
}
