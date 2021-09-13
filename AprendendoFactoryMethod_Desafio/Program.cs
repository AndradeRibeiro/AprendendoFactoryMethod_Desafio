using AprendendoFactoryMethod_Desafio.ConcreteProduct;
using AprendendoFactoryMethod_Desafio.Creator;
using AprendendoFactoryMethod_Desafio.Extensions;
using AprendendoFactoryMethod_Desafio.Product;
using System;

namespace AprendendoFactoryMethod_Desafio
{
    class Program
    {
        static void Main(string[] args)
        {
            CremeFactory cremeFactory = null;

            Console.Write("Digite o tipo de creme que gostaria de obter: ");
            Console.Write("\n 1 - Pentear \n 2 - Hidratação \n 3 - Condicionador \n 4 - Shampoo\n");

            int console = Convert.ToInt32(Console.ReadLine());

            switch (console)
            {
                case (int)TipoCremeEnum.CremePentear:
                    cremeFactory = new CremePentearFactory();
                    break;
                case (int)TipoCremeEnum.CremeHidratacao:
                    cremeFactory = new CremeHidratacaoFactory();
                    break;
                case (int)TipoCremeEnum.Condicionador:
                    cremeFactory = new CondicionadorFactory();
                    break;
                case (int)TipoCremeEnum.Shampoo:
                    cremeFactory = new ShampooFactory();
                    break;
                default:
                    break;
            }

            if (cremeFactory != null)
            {
                Creme creme = cremeFactory.BuscarInformacoes();

                Console.WriteLine("\n Detalhes do creme: \n");
                Console.WriteLine(" Tipo do creme: {0}\n Descrição: {1}\n Preço Mínimo: {2}",
                                   creme.Tipo.GetDisplayName(), creme.Descricao, creme.PrecoMinimo);
            }
            else
            {
                Console.WriteLine("\n Opção inválida \n");
            }

            Console.ReadKey();
        }
    }
}
