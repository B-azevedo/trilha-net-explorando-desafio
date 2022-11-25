using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sistema_de_reserva_de_hotel
{
    public class Suite
    {
        public string SuiteNumero { get; set; }
        public decimal ValorSuite { get; set; }
        public int Capacidade { get; set; }

        public Suite(string suiteX, decimal valorSuite, int capacidade)
        {
            SuiteNumero = suiteX;
            ValorSuite = valorSuite;
            Capacidade = capacidade;
        }
         
    }
}
