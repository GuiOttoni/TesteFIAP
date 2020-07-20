import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from "@angular/common/http";
import { BehaviorSubject, Observable, of, Subject } from "rxjs";
import { delay, map, switchMap } from "rxjs/operators";
import { Parceria } from './models/parceria';


@Injectable({
  providedIn: 'root'
})
export class ParceriaService {

  constructor(private http: HttpClient) { }

  public GetParcerias(
  ): Observable<Parceria[]> {
    return this.http.get<Parceria[]>(
      `http://localhost:5555/api/Parceria`
    );
  }

  public LikeParcerias(codigoParceria:number): Observable<Parceria[]> {
      return this.http.post<Parceria[]>(
        `http://localhost:5555/api/ParceriaLike/${codigoParceria}`, []
      );
    }

  public BuscaParcerias(texto:string
      ): Observable<Parceria[]> {
        return this.http.get<Parceria[]>(
          `http://localhost:5555/api/BuscaParceria/${texto}`
        );
  }
}
