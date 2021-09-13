using AprendendoFactoryMethod_Desafio.Product;

namespace AprendendoFactoryMethod_Desafio.ConcreteProduct
{
    public class Shampoo : Creme
    {
        public override string Descricao => "Utilizado para limpar o couro do cabeludo retirar as impurezas dos fios";
        public override double PrecoMinimo => 8.00;
        public override TipoCremeEnum Tipo => TipoCremeEnum.Shampoo;
    }

}
