import { ViewChild } from '@angular/core';
import { ElementRef } from '@angular/core';
import { Component, OnInit, AfterViewInit } from '@angular/core';
import { Router } from '@angular/router';

@Component({
  selector: 'app-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit, AfterViewInit {
  
  constructor(private router: Router) { }

  ngOnInit(): void {
  } 

  ngAfterViewInit() { 
  }

  goHome() {
    this.router.navigate(['home']);
  }

  goServerInfo() {
    this.router.navigate(['home']);
  }

  goDownloads() {
    this.router.navigate(['downloads']);
  }

  goRegistrar() {
    this.router.navigate(['registrar']);
  }

  goRankings() {
    this.router.navigate(['registrar']);
  }

  goDoacoes() {
    this.router.navigate(['registrar']);
  }
}
