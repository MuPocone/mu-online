import { NgModule } from '@angular/core';
import { Routes, RouterModule, PreloadAllModules } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { RegistrarUsuarioComponent } from './registrar-usuario/registrar-usuario.component';
import { DownloadsComponent } from './downloads/downloads.component';
import { ConfirmarComponent } from './confirmar/confirmar.component';
import { RecuperarSenhaComponent } from './recuperar-senha/recuperar-senha.component';

const routes: Routes = [

  { path: 'home', component: HomeComponent },
  { path: 'registrar', component: RegistrarUsuarioComponent },
  { path: 'downloads', component: DownloadsComponent },
  { path: 'confirmar', component: ConfirmarComponent },
  { path: 'recuperar-senha', component: RecuperarSenhaComponent },
  {
    path: '',
    redirectTo: 'home',
    pathMatch: 'full',
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes, {preloadingStrategy: PreloadAllModules})],
  exports: [RouterModule],
})
export class AppRoutingModule {}
