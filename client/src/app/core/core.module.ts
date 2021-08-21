import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HeaderComponent } from './layout/header/header.component';
import { ComponenteLateralComponent } from './layout/componente-lateral/componente-lateral.component';
import { LoginComponent } from './layout/componente-lateral/login/login.component';
import { PainelUsuarioComponent } from './layout/componente-lateral/painel-usuario/painel-usuario.component';
import { ServerInfoComponent } from './layout/componente-lateral/server-info/server-info.component';
import { CastleSiegeComponent } from './layout/componente-lateral/castle-siege/castle-siege.component';
import { EventsComponent } from './layout/componente-lateral/events/events.component';
import { FooterComponent } from './layout/footer/footer.component';
import { OutrosComponent } from './layout/componente-lateral/outros/outros.component';
import { AuthGuard } from './auth/auth.guard';
import { AuthService } from './auth/auth.service';
import { HTTP_INTERCEPTORS } from '@angular/common/http';
import { AuthInterceptor } from './auth/auth-interceptor';
import { ErrorInterceptor } from './auth/error-interceptor';
import { ReactiveFormsModule } from '@angular/forms';
import { RegistrarComponent } from './layout/componente-lateral/registrar/registrar.component';
import { DownloadComponent } from './layout/componente-lateral/download/download.component';
import { RouterModule } from '@angular/router';

@NgModule({
  declarations: [
    HeaderComponent,
    ComponenteLateralComponent,
    LoginComponent,
    PainelUsuarioComponent,
    ServerInfoComponent,
    CastleSiegeComponent,
    EventsComponent,
    FooterComponent,
    OutrosComponent,
    RegistrarComponent,
    DownloadComponent,
  ],
  imports: [
    CommonModule,
    ReactiveFormsModule,
    RouterModule
  ],
  exports: [
    HeaderComponent,
    ComponenteLateralComponent,
    LoginComponent,
    PainelUsuarioComponent,
    ServerInfoComponent,
    CastleSiegeComponent,
    EventsComponent,
    FooterComponent,
    OutrosComponent,
    RegistrarComponent,
    DownloadComponent,
    ReactiveFormsModule,
    RouterModule
  ],
  providers: [
    AuthGuard,
    AuthService,
    { provide: HTTP_INTERCEPTORS, useClass: AuthInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true }
  ]
})
export class CoreModule { }
