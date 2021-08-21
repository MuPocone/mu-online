import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { HttpService } from '../shared/http.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import { MU_API } from '../app.api';

@Component({
  selector: 'app-recuperar-senha',
  templateUrl: './recuperar-senha.component.html',
  styleUrls: ['./recuperar-senha.component.scss']
})
export class RecuperarSenhaComponent implements OnInit {

  statusBlock: boolean;
  statusLoading: boolean;
  formRecuperar = new FormGroup({
    nomeUsuario: new FormControl('', [Validators.minLength(4), Validators.maxLength(10)]),
    email: new FormControl('')
  });

  constructor(private http: HttpService, private snackBar: MatSnackBar) { }

  ngOnInit(): void {
  }

  get nomeUsuario() { return this.formRecuperar.get('nomeUsuario') }
  get email() { return this.formRecuperar.get('email') }

  recuperar() {
    const values = {
      nomeUsuario: this.formRecuperar.get('nomeUsuario').value,
      email: this.formRecuperar.get('email').value
    };

    if(!values.nomeUsuario && !values.email) this.openSnackBar('Preencha ao menos um dos campos.', 4000);

    this.statusBlock = true;
    this.statusLoading = true;

    this.http.post(`${MU_API}usuario/recuperar-senha`, values).subscribe((_) => {
      this.openSnackBar('Verifique teu e-mail, por favor.', 4000);
      setTimeout(() => {
        this.statusBlock = false;
        this.statusLoading = false;
      }, 4000);
    }, (error) => {
      this.statusLoading = false;
      this.statusBlock = false;
    });
  }

  openSnackBar(msg: string, time?: number) {
    this.snackBar.open(msg, null,
      {
        duration: time ?? 3000
      });
  }
}
