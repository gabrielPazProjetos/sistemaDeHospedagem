using DesafioProjetoHospedagem.Models;

var suite = new Suite("Premium", 2, 150.00M);
var reserva = new Reserva();
reserva.CadastrarSuite(suite);

var hospedes = new List<Pessoa>
{
    new Pessoa("Pessoa", "Um"),
    new Pessoa("Pessoa", "Dois")
};

reserva.CadastrarHospedes(hospedes);
reserva.DiasReservados = 12;

Console.WriteLine($"Quantidade de hóspedes: {reserva.ObterQuantidadeHospedes()}");
Console.WriteLine($"Valor total da reserva: {reserva.CalcularValorDiaria():C}");
