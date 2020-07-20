import { Component, OnInit, Input } from '@angular/core';
import { Parceria } from '../models/parceria';
import { ParceriaService } from '../parceria.service';
import { ParceriaDialogComponent } from '../parceria-dialog/parceria-dialog.component';
import { MatDialog } from '@angular/material/dialog';

@Component({
  selector: 'app-parceria',
  templateUrl: './parceria.component.html',
  styleUrls: ['./parceria.component.scss']
})
export class ParceriaComponent implements OnInit {

  @Input() parceria: Parceria;

  parceriaService:ParceriaService;

  constructor(parceriaService:ParceriaService, public dialog: MatDialog){
    this.parceriaService = parceriaService;
  }

  ngOnInit(): void {
  }

  registraLike(codigoParceria:number){
    this.parceriaService.LikeParcerias(codigoParceria).subscribe(res => { });
  }

  openDialog(p:Parceria) {
    this.dialog.open(ParceriaDialogComponent, {
      data: p
    });
  }

}
