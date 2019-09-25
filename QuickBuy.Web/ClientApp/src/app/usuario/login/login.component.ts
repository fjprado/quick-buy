import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {
  public usuario;
  public usuarioAutenticado: boolean;

  constructor(){
    this.usuario = new Usuario();
  }

  login() {
    if (this.usuario.email == "email.com.br" && this.usuario.senha == "abc") {
      this.usuarioAutenticado = true;
    }
  }
}
