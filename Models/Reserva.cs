using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_reserva_de_hotel
{
    public class Reserva
    {
        public List<Pessoa> Pessoas { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastroHospedes(List<Pessoa> pessoas)
        {
            if (Suite.Capacidade >= pessoas.Count)
            {

                Pessoas = pessoas;
            }
            else
            {
                throw new Exception("Não temos vagas disponiveis");

            }
        }
        public void CadastroSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantPessoas()
        {
            int ObterQuantPessoas = Pessoas.Count();
            return ObterQuantPessoas;
        }


        public decimal CalcularValorDiaria()
        {

            decimal valor = DiasReservados * Suite.ValorSuite;
            return valor;

            if (DiasReservados >= 10)
            {
                valor = valor - (valor * 10 / 100);
            }

            return valor;
        }
    }
}