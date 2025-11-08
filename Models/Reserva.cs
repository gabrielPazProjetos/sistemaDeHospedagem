using System;
using System.Collections.Generic;

namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if (Suite == null)
                throw new InvalidOperationException("A suíte deve ser cadastrada antes de adicionar hóspedes.");

            if (hospedes.Count > Suite.Capacidade)
                throw new ArgumentException("Número de hóspedes excede a capacidade da suíte.");

            Hospedes = hospedes;
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes?.Count ?? 0;
        }

        public decimal CalcularValorDiaria()
        {
            if (Suite == null)
                throw new InvalidOperationException("A suíte deve ser cadastrada para calcular o valor da diária.");

            decimal valor = DiasReservados * Suite.ValorDiaria;

            if (DiasReservados >= 10)
                valor *= 0.9M; // Aplica 10% de desconto

            return valor;
        }
    }
}
