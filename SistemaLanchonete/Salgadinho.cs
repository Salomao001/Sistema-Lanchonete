namespace Lanchonete
{
    public class Salgadinho : Prato
    {
        public Salgadinho()
        {

        }
        public Salgadinho(string nomePrato, string massa, string recheio, double precoVenda, DateTime dataValidade, double peso)
        : base(precoVenda, dataValidade, peso, nomePrato)
        {
            Recheio = recheio;
            Massa = massa;
        }
        private string Recheio { get; set; }
        private string Massa { get; set; }

        public string GetMassa()
        {
            return Massa;
        }

        public string GetRecheio()
        {
            return Recheio;
        }
    }
}