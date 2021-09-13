using AprendendoFactoryMethod_Desafio.Product;

namespace AprendendoFactoryMethod_Desafio.ConcreteProduct
{
    public class CremePentear : Creme
    {
        public override string Descricao => "Utilizado para desembaraçar, combater o frizz excessivo e modelar os fios";
        public override double PrecoMinimo => 10.00;
        public override TipoCremeEnum Tipo => TipoCremeEnum.CremePentear;
    }
}
