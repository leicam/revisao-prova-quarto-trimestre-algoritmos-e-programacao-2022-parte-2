using System;

namespace Revisão.Quatro.Trimestre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int menu = 1;

            #region do while

            //com o do while meu algoritmo
            //sera executado ao menos uma vez
            //do
            //{
            //    Console.WriteLine("ESCOLHA UMA OPÇÃO: ");
            //    Console.WriteLine("1 - Cadastrar Produto");
            //    Console.WriteLine("0 - Sair");

            //    switch (menu)
            //    {
            //        case 1:
            //            break;
            //        default:
            //            Console.WriteLine("Opção inválida!");
            //            break;
            //    }

            //    menu = int.Parse(Console.ReadLine());
            //} while (menu != 0);

            #endregion do while

            #region while

            while (menu != 0)
            {
                Console.WriteLine("ESCOLHA UMA OPÇÃO: ");
                Console.WriteLine("1 - Cadastrar Produto");
                Console.WriteLine("0 - Sair");

                menu = int.Parse(Console.ReadLine());

                switch (menu)
                {
                    case 1:
                        Produto produtoUm = new Produto(
                            "COCA-COLA 350ml", 2.99m, 10001);
                        
                        // modificador private set não permite que essa
                        // alteração ocorra
                        //produtoUm.Descricao = "GUARANÁ ANTARTICA";

                        Console.WriteLine(produtoUm.ToString());

                        break;
                    default:
                        Console.WriteLine("Opção inválida!");
                        break;
                }

            }

            #endregion while

            Console.WriteLine("Até mais!");
        }
    }
}