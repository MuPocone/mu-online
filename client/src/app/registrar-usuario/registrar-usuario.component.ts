import { Component, OnInit } from '@angular/core';
import { FormControl, FormGroup, Validators } from '@angular/forms';
import { HttpService } from '../shared/http.service';
import { MU_API } from '../app.api';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';

@Component({
  selector: 'app-registrar-usuario',
  templateUrl: './registrar-usuario.component.html',
  styleUrls: ['./registrar-usuario.component.scss']
})
export class RegistrarUsuarioComponent implements OnInit {

  statusLoading: boolean;
  formRegistro = new FormGroup({
    nomeUsuario: new FormControl('', [Validators.required, Validators.minLength(4), Validators.maxLength(10)]),
    senha: new FormControl('', [Validators.required, Validators.minLength(4), Validators.maxLength(10)]),
    email: new FormControl('', [Validators.required]),
    nome: new FormControl(null),
    telefone: new FormControl(null),
    dataNascimento: new FormControl(null)
  });

  statusBlock: boolean = false;

  constructor(private http: HttpService, private router: Router, private snackBar: MatSnackBar) { }

  ngOnInit(): void {
  }

  get nomeUsuario() { return this.formRegistro.get('nomeUsuario') }
  get senha() { return this.formRegistro.get('senha') }
  get email() { return this.formRegistro.get('email') }

  registrar() {
    if (this.formRegistro.valid) {
      this.statusBlock = true;
      this.statusLoading = true;
      const values = {
        nomeUsuario: this.formRegistro.get('nomeUsuario').value,
        senha: this.formRegistro.get('senha').value,
        nome: this.formRegistro.get('nome').value,
        email: this.formRegistro.get('email').value,
        telefone: this.formRegistro.get('telefone').value,
        dataNascimento: this.formRegistro.get('dataNascimento').value
      };

      this.http.post(`${MU_API}usuario`, values).subscribe((_) => {
        this.openSnackBar('Conta cadastrada com sucesso! Confirme o cadastro no seu e-mail para jogar.', 4000);
        setTimeout(() => {
          this.statusBlock = false;
          this.statusLoading = false;
          this.router.navigate(['/home']);
        }, 6000);
      }, (error) => {
        this.openSnackBar(error.error, 3000);
        this.statusLoading = false;
        this.statusBlock = false;
      });
    } else { this.openSnackBar('Ta querendo burla o sistema? OLOCOO, tenta ai kkk', 4000); }
  }

  openSnackBar(msg: string, time?: number) {
    this.snackBar.open(msg, null,
      {
        duration: time ?? 3000
      });
  }

}
