import { Component, OnInit } from '@angular/core';
import { FormGroup, FormControl } from '@angular/forms';

@Component({
  selector: 'app-componente-lateral',
  templateUrl: './componente-lateral.component.html',
  styleUrls: ['./componente-lateral.component.scss']
})
export class ComponenteLateralComponent implements OnInit {

  public formStatus = new FormGroup({
    logado: new FormControl(''),
    nomeUsuario: new FormControl('')
  });

  constructor() { }

  ngOnInit(): void {
    const user: any = JSON.parse(localStorage.getItem('usuario')); 
    this.formStatus.get('logado').setValue(user != undefined && user != null ? true : false);
    this.formStatus.get('nomeUsuario').setValue(user != undefined && user != null ? user.nomeUsuario : '');
  } 
}
