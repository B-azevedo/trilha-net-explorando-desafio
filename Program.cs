using System.Text;


namespace Sistema_de_reserva_de_hotel
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

            List<Pessoa> pessoas = new List<Pessoa>();

            Pessoa p1 = new Pessoa(nome: "Hóspede 1");
            Pessoa p2 = new Pessoa(nome: "Hóspede 2");

            pessoas.Add(p1);
            pessoas.Add(p2);

            Suite suite = new Suite(suiteX: "Premium", capacidade: 4, valorSuite: 30);

            Reserva reserva = new Reserva(diasReservados: 10);
            reserva.CadastroSuite(suite);
            reserva.CadastroHospedes(pessoas);

            Console.WriteLine($"Hóspedes: {reserva.ObterQuantPessoas()}");
            Console.WriteLine($"Valor diária: {reserva.CalcularValorDiaria()}");
        }
    }
}