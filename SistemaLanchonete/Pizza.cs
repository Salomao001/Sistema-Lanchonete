namespace Lanchonete
{
    public class Pizza : Prato
    {
        public Pizza()
        {

        }
        public Pizza(string nomePrato, string molho, string recheio, string borda, double precoVenda, DateTime dataValidade, double peso)
        : base(precoVenda, dataValidade, peso, nomePrato)
        {
            Molho = molho;
            Recheio = recheio;
            Borda = borda;
        }

        private string Molho { get; set; }
        private string Recheio { get; set; }
        private string Borda { get; set; }

        public string GetMolho()
        {
            return Molho;
        }

        public string GetRecheio()
        {
            return Recheio;
        }

        public string GetBorda()
        {
            return Borda;
        }
    }
}