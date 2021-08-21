import { Component, OnInit, Input } from '@angular/core';
import { FormGroup, FormControl, Validators } from '@angular/forms';
import { HttpService } from 'src/app/shared/http.service';
import { MU_API } from './../../../../app.api';
import { MatSnackBar } from '@angular/material/snack-bar';

@Component({
  selector: 'app-login',
  templateUrl: './login.component.html',
  styleUrls: ['./login.component.scss']
})
export class LoginComponent implements OnInit {

  formLogin = new FormGroup({
    login: new FormControl('', [Validators.required, Validators.minLength(4)]),
    senha: new FormControl('', [Validators.required, Validators.minLength(4)])
  });

  @Input() form: FormGroup = undefined;

  private msgStatus: string;
  statusBlock: boolean = false;
  statusLoading: boolean = false;

  constructor(private http: HttpService, private snackBar: MatSnackBar) { }

  ngOnInit(): void {
  }

  public logar() {
    if (this.formLogin.valid) {
      this.statusBlock = true;
      this.statusLoading = true;
      const usuario: any = {
        nomeUsuario: this.formLogin.get('login').value,
        senha: this.formLogin.get('senha').value
      };

      if (usuario.nomeUsuario != undefined && usuario.nomeUsuario != null) {
        if (usuario.senha != undefined && usuario.senha != null) {
          this.http.post(`${MU_API}usuario/autenticar`, usuario).subscribe((resp) => { 
            localStorage.setItem('usuario', JSON.stringify(resp));
            this.form.get('logado').setValue(true); 
            this.form.get('nomeUsuario').setValue(resp.nomeUsuario); 
            this.statusLoading = false;
            this.statusBlock = false;
          }, (err) => { 
            this.openSnackBar(err.error);
            this.statusLoading = false;
            this.statusBlock = false;
          });
        }
      }
    } else { this.openSnackBar('Poww xomano(a)! Preenche ai pra nós o usuário e senha.', 4000); }
  }

  openSnackBar(msg: string, time?: number) {
    this.snackBar.open(msg, null, { duration: time ?? 3000 });
  }
}
