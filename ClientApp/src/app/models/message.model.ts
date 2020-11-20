export class Message {
  constructor(public body: string, public userId: string, public chatId: string) {
  }

  id: string;
}
