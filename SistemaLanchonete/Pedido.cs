namespace Lanchonete
{
    public class Pedido
    {
        public Pedido(string nomeCliente)
        {
            NomeCliente = nomeCliente;
            TaxaServico = 10.0;
            ItensConsumidos = new List<Prato>();
        }
        private string NomeCliente { get; set; }
        private double TaxaServico { get; set; }
        private IList<Prato> ItensConsumidos { get; set; }

        public string GetNome()
        {
            return NomeCliente;
        }
        public double GetTaxa()
        {
            return TaxaServico;
        }

    }
}