import { Injectable, Injector } from '@angular/core';
import { AuthService } from './auth.service';
import { MatSnackBar } from '@angular/material/snack-bar';
import { Router } from '@angular/router';
import {
  HttpInterceptor,
  HttpRequest,
  HttpResponse,
  HttpHandler,
  HttpEvent,
  HttpErrorResponse
} from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { map, catchError } from 'rxjs/operators';

@Injectable()
export class ErrorInterceptor implements HttpInterceptor {

  constructor(private injector: Injector, private router: Router, private snackBar: MatSnackBar) {
  }

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    const authenticationService = this.injector.get(AuthService);

    request = request.clone({ headers: request.headers.set('Accept', 'application/json') });

    return next.handle(request).pipe(
      map((event: HttpEvent<any>) => {
        if (event instanceof HttpErrorResponse) {
          if (event.status === 401) {
            // auto logout if 401 response returned from api
            authenticationService.logout();
            this.router.navigate(['/home']); 
          }

          if (event.status === 400) {
            this.openSnackBar(event.error); 
          }

          if (event.status === 500) {
            catchError(event.error);
          } 
        } 
        return event;
      }));
  }

  openSnackBar(msg: string, time?: number) {
    this.snackBar.open(msg, null,
      {
        duration: time ?? 3000
      });
  }
}