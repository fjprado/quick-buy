using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace QuickBuy.Dominio.Entidades
{
    public abstract class Entidade
    {
        public List<string> _mensagensValidacao { get; set; }
        private List<string> mensagemValidacao 
        {
            get { return _mensagensValidacao ?? (_mensagensValidacao = new List<string>());}
            //O operador ?? retorna o componente a esquerda, se este não for nulo. Caso contrário, retornará o componente da direita.
            //Neste caso, se não houver nenhuma mensagem de validação, o sistema irá criar uma nova lista de mensagens.
        }

        protected void LimparMensagens()
        {
            mensagemValidacao.Clear();
        }

        protected void AdicionarCritica(string mensagem)
        {
            mensagemValidacao.Add(mensagem);
        }

        public abstract void Validate();
        protected bool EhValido
        {
           get { return !mensagemValidacao.Any();}     
        }
    }
}
