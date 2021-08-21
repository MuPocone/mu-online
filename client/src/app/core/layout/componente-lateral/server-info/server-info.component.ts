import { Component, OnInit } from '@angular/core';
import { HttpService } from 'src/app/shared/http.service';
import { MU_API } from './../../../../app.api';
import { Observable } from 'rxjs';

@Component({
  selector: 'app-server-info',
  templateUrl: './server-info.component.html',
  styleUrls: ['./server-info.component.scss']
})
export class ServerInfoComponent implements OnInit {

  public usersOnline: number = 0;
  public totalContas: number = 0;
  
  constructor(private http: HttpService) { }

  ngOnInit(): void {
    this.getAccount();
    this.getUsersOnline();

    setInterval(() => {
      this.getUsersOnline();
    }, 60000);
  }

  getAccount() {
    this.http.get(`${MU_API}usuario/contas`).subscribe((resp) => {
      this.totalContas = resp;
    });
  }

  getUsersOnline() { 
    this.http.get(`${MU_API}usuario/online`).subscribe((resp) => {
      this.usersOnline = resp;
    });
  }
}
