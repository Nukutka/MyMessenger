import {Component, EventEmitter, OnInit, Output} from '@angular/core';
import {Chat} from '../../models/chat.model';

@Component({
  selector: 'app-left-bar',
  templateUrl: './left-bar.component.html',
  styleUrls: ['./left-bar.component.scss']
})
export class LeftBarComponent implements OnInit {

  constructor() { }

  ngOnInit(): void {
  }

  @Output() selectedChatEvent = new EventEmitter<Chat>();

  public selectedChat(chat: Chat): void {
    this.selectedChatEvent.emit(chat);
  }
}
