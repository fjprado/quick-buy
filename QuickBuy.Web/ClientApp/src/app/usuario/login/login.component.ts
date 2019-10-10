import { Component, OnInit } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router, RouterStateSnapshot, ActivatedRoute} from "@angular/router";
import { UsuarioServico } from "../../servicos/usuario/usuario.servico";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent implements OnInit {

  public usuario;
  public returnUrl: string;

  constructor(private router: Router, private activatedRoute: ActivatedRoute, private usuarioServico: UsuarioServico) {
  }

  ngOnInit(): void {
    this.usuario = new Usuario();
    this.returnUrl = this.activatedRoute.snapshot.queryParams["returnUrl"];
  }

  login() {

    this.usuarioServico.verificarUsuario(this.usuario).
      subscribe(
        data => {
        },
        err => {
        }
    );


    //if (this.usuario.email == "email.com.br" && this.usuario.senha == "abc") {
    //  sessionStorage.setItem("usuario-autenticado", "1");
    //  this.router.navigate([this.returnUrl]);
    //}
  }
}
