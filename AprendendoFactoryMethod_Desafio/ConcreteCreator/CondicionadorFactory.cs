using AprendendoFactoryMethod_Desafio.Creator;
using AprendendoFactoryMethod_Desafio.Product;

namespace AprendendoFactoryMethod_Desafio.ConcreteProduct
{
    public class CondicionadorFactory : CremeFactory
    {
        public override Creme BuscarInformacoes()
        {
            return new Condicionador();
        }
    }
}
