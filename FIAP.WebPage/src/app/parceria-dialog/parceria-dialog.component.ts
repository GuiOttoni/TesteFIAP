import { Component, OnInit, Inject } from '@angular/core';
import { MAT_DIALOG_DATA } from '@angular/material/dialog';
import { Parceria } from '../models/parceria';

@Component({
  selector: 'app-parceria-dialog',
  templateUrl: './parceria-dialog.component.html',
  styleUrls: ['./parceria-dialog.component.scss']
})
export class ParceriaDialogComponent implements OnInit {

  constructor(@Inject(MAT_DIALOG_DATA) public data: Parceria) {}

  ngOnInit(): void {
  }

}
