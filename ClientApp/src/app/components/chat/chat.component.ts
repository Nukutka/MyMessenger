import {Component, OnInit, NgZone} from '@angular/core';
import {Message} from '../../models/message.model';
import {MessageService} from '../../services/message.service';
import {Chat} from '../../models/chat.model';
import {CdkScrollable, ScrollDispatcher} from '@angular/cdk/scrolling';
import {newArray} from "@angular/compiler/src/util";

@Component({
  selector: 'app-chat',
  templateUrl: './chat.component.html',
  styleUrls: ['./chat.component.scss']
})
export class ChatComponent implements OnInit {
  chat: Chat;
  messages: Message[];
  userId: string;
  messagesOffset: number;

  oldScrollHeightValue: number;

  constructor(private messageService: MessageService, private scrollDispatcher: ScrollDispatcher, private zone: NgZone) {
    this.userId = localStorage.getItem('userId');
    this.scrollDispatcher.scrolled().subscribe((cdk: CdkScrollable) => this.scrollTopEvent(cdk));
    this.messagesOffset = 0;
    this.messages = newArray<Message>(0);
    this.oldScrollHeightValue = 0;
  }

  ngOnInit(): void {
  }

  private scrollTopEvent(cdk: CdkScrollable): void {
    this.zone.run(() => {
      const scrollOffset = cdk.getElementRef().nativeElement.scrollTop || 0;

      if (scrollOffset === 0) {
        this.messagesOffset += 20;
        this.loadMessages(this.messagesOffset);
      }
    });
  }

  public setChat(chat: Chat): void {
    this.chat = chat;
    this.messages = newArray<Message>(0);
    this.messagesOffset = 0;
    this.loadMessages(0);
  }

  public loadMessages(offset: number): void {
    this.messageService.getMessages(this.chat.id, offset).subscribe(data => {
        this.messages = data.concat(this.messages);
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
