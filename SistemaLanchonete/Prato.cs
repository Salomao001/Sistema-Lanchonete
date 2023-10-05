namespace Lanchonete
{
    public abstract class Prato
    {
        public Prato()
        {

        }
        public Prato(double precoVenda, DateTime dataValidade, double peso, string nomePrato)
        {
            PrecoVenda = precoVenda;
            DataValidade = dataValidade;
            Peso = peso;
            NomePrato = nomePrato;
        }
        private string NomePrato { get; set; }
        private double PrecoVenda { get; set; }
        private DateTime DataValidade { get; set; }
        private double Peso { get; set; }

        public double GetPreco()
        {
            return PrecoVenda;
        }

        public string getNomePrato()
        {
            return NomePrato;
        }
    }
}