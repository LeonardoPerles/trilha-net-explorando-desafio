namespace DesafioProjetoHospedagem.Models
{
    public class Reserva
    {
        public List<Pessoa> Hospedes { get; set; }
        public Suite Suite { get; set; }
        public int DiasReservados { get; set; }

        public Reserva() { }

        public Reserva(int diasReservados)
        {
            DiasReservados = diasReservados;
        }

        public void CadastrarHospedes(List<Pessoa> hospedes)
        {
            if ( Suite.Capacidade >= hospedes.Count())
            {
                Hospedes = hospedes;
            }
            else
            {
                throw new Exception("Não é possível cadastrar, o numero de hospedes ultrapassa o limite.");
            }
        }

        public void CadastrarSuite(Suite suite)
        {
            Suite = suite;
        }

        public int ObterQuantidadeHospedes()
        {
            return Hospedes.Count();
        }

        public decimal CalcularValorDiaria()
        {
            decimal valor = DiasReservados * Suite.ValorDiaria;
            decimal percentualDesconto = 10.0m;
            
            if (DiasReservados >= 10)
            {
                valor -= valor / percentualDesconto;
            }

            return valor;
        }
    }
}