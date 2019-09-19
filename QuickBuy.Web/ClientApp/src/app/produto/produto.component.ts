import {Component} from "@angular/core"

@Component({
  selector: "app-produto",
  template: "<html><body>{{GetNome()}}</body></html>"
})
 export class ProdutoComponent {
  public nome: string = "Fernando";

  public GetNome() :string {
    return this.nome;
  }
}
