using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_reserva_de_hotel
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
     

        public Pessoa(string nome)
        {
            Nome = nome;
        }

        public Pessoa(string nome, string sobrenome)
        {
            Nome = nome;
            Sobrenome = sobrenome;
        }
        
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();
    }
}