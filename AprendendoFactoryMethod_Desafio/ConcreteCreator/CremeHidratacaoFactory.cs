using AprendendoFactoryMethod_Desafio.Creator;
using AprendendoFactoryMethod_Desafio.Product;

namespace AprendendoFactoryMethod_Desafio.ConcreteProduct
{
    public class CremeHidratacaoFactory : CremeFactory
    {
        public override Creme BuscarInformacoes()
        {
            return new CremeHidratacao();
        }
    }
}
