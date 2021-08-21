import {HttpEvent, HttpHandler, HttpInterceptor, HttpRequest} from '@angular/common/http';
import {Injectable} from '@angular/core';
import {Observable} from 'rxjs'; 

@Injectable()
export class AuthInterceptor implements HttpInterceptor {
  constructor() {
  }

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    
    const usuario: any = localStorage.getItem('usuario'); 
    if (usuario?.accessToken) {
      request = request.clone({ headers: request.headers.set('Authorization', 'Bearer ' + usuario?.accessToken) });
    } 

    return next.handle(request);
  } 
}
