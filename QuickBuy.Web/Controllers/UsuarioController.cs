using Microsoft.AspNetCore.Mvc;
using QuickBuy.Dominio.Entidades;
using System;

namespace QuickBuy.Web.Controllers
{
    [Route("api/[Controller]")]
    public class UsuarioController : Controller 
    {
        [HttpPost]
        public ActionResult Post()
        {
            try
            {
                return Ok();
            }catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpPost("VerificarUsuario")]
        public ActionResult VerificarUsuario([FromBody] Usuario usuario)
        {
            try
            {
                if(usuario.Email == "email.com.br" && usuario.Senha == "abc")
                    return Ok(usuario);
                return BadRequest("Usuario ou senha inválidos!!!");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
        }

        [HttpGet]
        public ActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
    }
}
