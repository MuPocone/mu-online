import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { HttpService } from '../shared/http.service';
import { MU_API } from './../app.api';

@Component({
  selector: 'app-confirmar',
  templateUrl: './confirmar.component.html',
  styleUrls: ['./confirmar.component.scss']
})
export class ConfirmarComponent implements OnInit {
  statusConfirmacao: boolean;
  statusLoading: boolean;
  message: string = "Conectando ao servidor...";
  constructor(private activatedRoute: ActivatedRoute, private http: HttpService) { }

  ngOnInit(): void {
    this.message = "Confirmando cadastro";
    this.activatedRoute.queryParams.subscribe(params => {
      const hash = params.hash;
      if (hash) {
        this.statusLoading = true;
        this.http.post(`${MU_API}usuario/confirmar?hash=${hash}`, null).subscribe((resp) => {
          this.message = "Cadastro Confirmado";
          this.statusConfirmacao = true;
        }, (err) => {
          this.statusLoading = false;
          this.statusConfirmacao = false;
          this.message = "Tente novamente";
        });
      } else {
        this.message = "Cadastro Confirmado";
      }
    });
  }
}
