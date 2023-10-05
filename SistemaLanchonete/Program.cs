

namespace Lanchonete
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            Console.WriteLine("***Bem vindo a lanchonete do fluxo***");
            Console.Write("Gosaria de fazer um pedido? (S/N): ");
            var perguntaPedido = Console.ReadLine();

            switch (perguntaPedido.ToUpper())
            {
                case "S": FazerPedido(); break;
                case "N": Environment.Exit(0); break;
                default: Menu(); break;
            }
        }

        static void FazerPedido()
        {
            Console.Write("Nome do Cliente: ");
            var nomeCliente = Console.ReadLine();
            var pedido = new Pedido(nomeCliente);
            var itens = new List<Prato>();
            Pizza pizza = new();
            Lanche lanche = new();
            Salgadinho salgadinho = new();
            while (true)
            {



                Console.Write("Escolha o prato (pizza = 1 - lanche = 2 - salgadinho = 3 - finalizar pedido = 0): ");
                var escolha = Convert.ToInt16(Console.ReadLine());


                if (escolha == 1)
                {
                    Console.WriteLine("Escolha a pizza");
                    Console.WriteLine("Pizza de Mussarela (1)");
                    Console.WriteLine("Pizza de Gorgonzola (2)");
                    Console.WriteLine("Pizza de Calabresa (3)");
                    var pizzaPedido = Convert.ToInt16(Console.ReadLine());
                    switch (pizzaPedido)
                    {
                        case 1: pizza = new Pizza("Pizza de mussarela", "tomate", "mussarela", "sem borda", 50, DateTime.Now.AddDays(10), 40); break;
                        case 2: pizza = new Pizza("Pizza de gorgonzola", "parsisense", "gorgonzola", "borda catupiry", 65, DateTime.Now.AddDays(10), 50); break;
                        case 3: pizza = new Pizza("Pizza de Calabresa", "tomate", "calabresa", "borda cheddar", 55, DateTime.Now.AddDays(10), 45); break;
                    }
                    itens.Add(pizza);
                }
                else if (escolha == 2)
                {
                    Console.WriteLine("Escolha o lanche");
                    Console.WriteLine("Hamburguer (1)");
                    Console.WriteLine("Misto quente (2)");
                    var lanchePedido = Convert.ToInt16(Console.ReadLine());
                    switch (lanchePedido)
                    {
                        case 1: lanche = new Lanche("Hamburguer", "barbecue", "patinho", "pão brioche", 20, DateTime.Now.AddDays(10), 40); break;
                        case 2: lanche = new Lanche("Misto quente", "maionese", "presunto e queijo", "pão frances", 10, DateTime.Now.AddDays(10), 50); break;
                    }
                    itens.Add(lanche);
                }
                else if (escolha == 3)
                {
                    Console.WriteLine("Escolha o lanche");
                    Console.WriteLine("Coxinha (1)");
                    Console.WriteLine("Enroladinho de salsicha (2)");
                    var salgadinhoePedido = Convert.ToInt16(Console.ReadLine());
                    switch (salgadinhoePedido)
                    {
                        case 1: salgadinho = new Salgadinho("Coxinha", "batata", "frango", 7, DateTime.Now.AddDays(10), 40); break;
                        case 2: salgadinho = new Salgadinho("Enroladinho de salsicha", "mandioca", "salcicha", 7, DateTime.Now.AddDays(10), 50); break;
                    }
                    itens.Add(salgadinho);
                }
                else if (escolha == 0)
                {
                    break;
                }
            }
            MostrarPedido(itens, pedido);
            CalculaPreco(itens, pedido);
        }

        static void CalculaPreco(IList<Prato> itens, Pedido pedido)
        {
            double taxa = pedido.GetTaxa();
            double custoTotal = 0;
            for (int i = 0; i < itens.Count; i++)
            {
                custoTotal += itens[i].GetPreco();
            }
            Console.WriteLine("valor total a pagar: {0:C}", custoTotal + taxa);
        }

        static void MostrarPedido(IList<Prato> itens, Pedido pedido)
        {
            var nome = pedido.GetNome();
            Console.WriteLine($"Carrinho de {nome}");
            Console.WriteLine("---------------------");
            foreach (var item in itens)
            {
                Console.WriteLine(item.getNomePrato());
            }
            Console.WriteLine("---------------------");
        }
    }
}