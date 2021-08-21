import { Component, OnInit, Input, OnChanges, SimpleChanges } from '@angular/core';
import { FormGroup } from '@angular/forms';

@Component({
  selector: 'app-painel-usuario',
  templateUrl: './painel-usuario.component.html',
  styleUrls: ['./painel-usuario.component.scss']
})
export class PainelUsuarioComponent implements OnInit, OnChanges {

  @Input() form: FormGroup = undefined;
  public nomeUsuario: string;

  constructor() { }
  
  ngOnChanges(changes: SimpleChanges): void {
    for (const propName in changes) { 
      const change = changes[propName];
      this.nomeUsuario = change.currentValue.value.nomeUsuario;
    }
  }

  ngOnInit(): void {
  }

  sair() {
    localStorage.removeItem('usuario');
    this.form.get('logado').setValue(false);
  }
}
