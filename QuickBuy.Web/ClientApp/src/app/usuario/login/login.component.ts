import { Component } from "@angular/core";
import { Usuario } from "../../modelo/usuario";
import { Router, RouterStateSnapshot} from "@angular/router";

@Component({
  selector: "app-login",
  templateUrl: "./login.component.html",
  styleUrls: ["./login.component.css"]
})
export class LoginComponent {
  public usuario;

  constructor(private router: Router) {
    this.usuario = new Usuario();
  }

  login() {
    if (this.usuario.email == "email.com.br" && this.usuario.senha == "abc") {
      localStorage.setItem("usuario-autenticado", "1");
      this.router.navigate(['/']);
    }
  }
}
