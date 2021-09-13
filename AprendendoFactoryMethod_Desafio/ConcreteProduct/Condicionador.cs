using AprendendoFactoryMethod_Desafio.Product;

namespace AprendendoFactoryMethod_Desafio.ConcreteProduct
{
    public class Condicionador : Creme
    {
        public override string Descricao => "Utilizado para fechar as escamas e dá maciez aos fios";
        public override double PrecoMinimo => 9.50;
        public override TipoCremeEnum Tipo => TipoCremeEnum.Condicionador;
    }
}
