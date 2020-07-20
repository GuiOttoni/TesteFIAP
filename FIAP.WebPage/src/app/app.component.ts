import { Component } from '@angular/core';
import { Parceria } from './models/parceria';
import { ParceriaService } from './parceria.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  parceriaService: ParceriaService

  title = 'FIAPWebpage';
  public searchValue = 'Insira o texto para pesquisa';

  parcerias = new Array<Parceria>();

  constructor(parceriaService:ParceriaService){
    this.parceriaService = parceriaService;
  }


  ngOnInit(): void {
    this.parceriaService.GetParcerias().subscribe(res => {
      this.parcerias = res;
    });
  }

  pesquisar(texto:string){
    this.parceriaService.BuscaParcerias(texto).subscribe(res =>
      {
        this.parcerias = res;
      });
  }
}
