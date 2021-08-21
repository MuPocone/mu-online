import { Component, OnInit, AfterViewInit } from '@angular/core';
import { MatSnackBar, MatSnackBarConfig } from '@angular/material/snack-bar';

@Component({
  selector: 'app-termos-condicoes',
  templateUrl: './termos-condicoes.component.html',
  styleUrls: ['./termos-condicoes.component.scss']
})
export class TermosCondicoesComponent implements OnInit, AfterViewInit {

  constructor(private snackBar: MatSnackBar) { }

  ngOnInit(): void {
  }
  ngAfterViewInit() {
    var aceite = localStorage.getItem('aceite-termo');
    if (!aceite)
      this.snackbarSuccess(`Utilizamos cookies para melhorar a sua experiência no site. Os dados eventualmente informados pelo usuário que utilizar o formulário de cadastro disponibilizado no site, incluindo o teor da mensagem enviada, serão coletados e armazenados. Ao continuar navegando,
    você permite.`);
  }

  private configSuccess: MatSnackBarConfig = {
    panelClass: ['style-success'],
  };

  public snackbarSuccess(message) {
    this.snackBar.open(message, 'FECHAR E CONTINUAR', this.configSuccess)
      .afterDismissed()
      .subscribe(() => { 
        localStorage.setItem('aceite-termo', 'true');
      });
  }
}
