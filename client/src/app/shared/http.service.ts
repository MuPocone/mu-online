import {Injectable} from '@angular/core';
import {HttpClient, HttpHeaders} from '@angular/common/http';
import {Observable} from 'rxjs'; 

@Injectable({
  providedIn: 'root'
})
export class HttpService {

  constructor(private http: HttpClient) {
  }

  get<T>(url, options?: any): Observable<any> {
    return this.http.get(url, this.prepareOptions(options));
  }

  post<T>(url, body, options?: any): Observable<any> {
    return this.http.post(url, JSON.stringify(body), this.prepareOptions(options));
  }

  put<T>(url, body, options?: any): Observable<any> {
    return this.http.put(url, body, this.prepareOptions(options));
  }

  delete<T>(url, options?: any): Observable<any> {
    return this.http.get(url, this.prepareOptions(options));
  }

  prepareOptions(options?: any) {
    if (options != undefined && options != null) {
      return options;
    } else { 
      const httpOptions = {
        headers: new HttpHeaders({
          'Content-Type': 'application/json; charset=utf-8',
          'Access-Control-Allow-Methods': 'POST, GET, OPTIONS, DELETE, PUT'
        })
      };
      return httpOptions;
    }
  }
}
