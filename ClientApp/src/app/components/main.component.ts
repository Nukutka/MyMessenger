import { Component, OnInit, ViewChild } from '@angular/core';
import {Chat} from '../models/chat.model';
import {ChatComponent} from './chat/chat.component';

@Component({
  selector: 'app-main',
  templateUrl: './main.component.html',
  styleUrls: ['./main.component.scss']
})
export class MainComponent implements OnInit {
  @ViewChild(ChatComponent) chatComponent: ChatComponent;

  constructor() { }

  ngOnInit(): void {
  }

  selectedChat(chat: Chat): void{
    this.chatComponent.setChat(chat);
  }

}
