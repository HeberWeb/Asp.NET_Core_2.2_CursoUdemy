import { Component, OnInit } from '@angular/core';

@Component({
  selector: 'app-eventos',
  templateUrl: './Eventos.component.html',
  styleUrls: ['./Eventos.component.css']
})
export class EventosComponent implements OnInit {

  eventos: any = [
    {
      EventoId: 1,
      Tema: 'Angular',
      Local: 'São Paulo'
    },
    {
      EventoId: 2,
      Tema: 'NetCore',
      Local: 'Ria de Janeiro'
    },
    {
      EventoId: 3,
      Tema: 'TS Script',
      Local: 'Bahia'
    }
  ];

  constructor() { }

  ngOnInit() {
  }

}
