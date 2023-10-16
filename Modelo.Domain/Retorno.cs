using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo.Domain
{
    public class Retorno
    {
        public bool Sucesso { get; set; }
        public string Mensagem { get; set; }
        public int StatusCode { get; set; }

        public void CarregaRetorno(bool sucesso, string mensagem, int statuscode)
        {
            Sucesso = sucesso;
            Mensagem = mensagem;
            StatusCode = statuscode;
        }
    }

    public class Retorno<T> : Retorno where T : class
    {
        public T Modelo { get; set; }
        public void CarregaRetorno(T modelo, bool sucesso, string mensagem, int statuscode)
        {
            Modelo = modelo;
            Sucesso = sucesso;
            Mensagem = mensagem;
            StatusCode = statuscode;
        }
        public Retorno(T modelo)
        {
            Modelo = modelo;
        }
    }
}
