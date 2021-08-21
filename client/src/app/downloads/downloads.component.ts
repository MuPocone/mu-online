import { Component, OnInit } from '@angular/core';
import { environment } from './../../environments/environment';

@Component({
  selector: 'app-downloads',
  templateUrl: './downloads.component.html',
  styleUrls: ['./downloads.component.scss']
})
export class DownloadsComponent implements OnInit {
  private urlBase: string;

  constructor() { 
    this.urlBase = environment.URL_BASE;
  }

  ngOnInit(): void {
  }

  goDownloads() {
    var link: any = document.createElementNS("http://www.w3.org/1999/xhtml", "a");
    link.href = 'www.URL_DE_DOWNLOAD.com.br';
    link.target = '_blank';
    var event = new MouseEvent('click', {
        'view': window,
        'bubbles': false,
        'cancelable': true
    });
    link.dispatchEvent(event);
  } 
}
