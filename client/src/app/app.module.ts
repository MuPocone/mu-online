import { CoreModule } from './core/core.module';
import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HomeComponent } from './home/home.component';
import { DownloadsComponent } from './downloads/downloads.component';
import { ConfirmarComponent } from './confirmar/confirmar.component';
import { RegistrarUsuarioComponent } from './registrar-usuario/registrar-usuario.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';

import { MatExpansionModule } from '@angular/material/expansion';
import { MatCardModule } from '@angular/material/card';
import { MatSnackBarModule } from '@angular/material/snack-bar';
import { HttpClientModule } from '@angular/common/http';
import { RecuperarSenhaComponent } from './recuperar-senha/recuperar-senha.component';
import { TermosCondicoesComponent } from './termos-condicoes/termos-condicoes.component';


@NgModule({
  declarations: [AppComponent, HomeComponent, DownloadsComponent, RegistrarUsuarioComponent, ConfirmarComponent, RecuperarSenhaComponent, TermosCondicoesComponent],
  imports: [
    BrowserModule,
    AppRoutingModule,
    BrowserAnimationsModule,
    CoreModule,
    HttpClientModule,
    MatExpansionModule,
    MatCardModule,
    MatSnackBarModule
  ],
  exports: [
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent],
})
export class AppModule { }
