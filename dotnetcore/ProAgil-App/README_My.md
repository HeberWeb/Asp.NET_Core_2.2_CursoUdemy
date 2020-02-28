# Seção 3: Angular

## Alguns comandos que foram necessários.
* npm install -g @angular/cli
* ng new ProAgil-App - para criar o projeto
* ng serve -o para compilar e abrir

## Obs request http
* import { HttpClientModule } from '@angular/common/http'; em app.modules e no obj NgModule > imports
* ngOnInit realiza antes de ler o html para chamadas de métodos.

## Importante:
* *ng... Structural Directive (Deritiva estrutural)
* [...] Property Binding
* {{...}} Interpolation ou [(ngModel)]="variavel" para two-way data binding
* (event) click por exemplo: <el (click)='method'>

## Usar two-way data binding
import { FormsModule } from '@angular/forms'; em app.modules e no obj NgModule > imports