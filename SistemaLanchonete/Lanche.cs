namespace Lanchonete
{
    public class Lanche : Prato
    {
        public Lanche()
        {

        }
        public Lanche(string nomePrato, string molho, string recheio, string pao, double precoVenda, DateTime dataValidade, double peso)
        : base(precoVenda, dataValidade, peso, nomePrato)
        {
            Pao = pao;
            Molho = molho;
            Recheio = recheio;
        }

        private string Pao { get; set; }
        private string Recheio { get; set; }
        private string Molho { get; set; }


        public string GetMolho()
        {
            return Molho;
        }

        public string GetRecheio()
        {
            return Recheio;
        }

        public string GetPao()
        {
            return Pao;
        }
    }
}