import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { RouterModule } from '@angular/router';
import { AppComponent } from './app.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import {MaterialModule} from './material.module';
import { TopBarComponent } from './components/top-bar/top-bar.component';
import { MainComponent } from './components/main.component';
import { LeftBarComponent } from './components/left-bar/left-bar.component';
import { ContactListComponent } from './components/left-bar/contact-list/contact-list.component';
import { ChatComponent } from './components/chat/chat.component';


@NgModule({
  declarations: [
    AppComponent,
    TopBarComponent,
    MainComponent,
    LeftBarComponent,
    ContactListComponent,
    ChatComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    RouterModule.forRoot([
      { path: '', component: MainComponent },
      // { path: 'login', component: AuthComponent },
      { path: '**', redirectTo: '/'}
    ]),
    BrowserAnimationsModule,
    MaterialModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
