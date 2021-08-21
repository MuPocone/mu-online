import {Injectable} from '@angular/core'; 
  
@Injectable()
export class AuthService { 

  constructor( ) {
  } 

  getUser() {
    const user: any = JSON.parse(localStorage.getItem('user'));
    const separa = user.nome.split(' ');
    return separa[0];
  } 

  logout() {
    localStorage.removeItem('user');
  } 
}
