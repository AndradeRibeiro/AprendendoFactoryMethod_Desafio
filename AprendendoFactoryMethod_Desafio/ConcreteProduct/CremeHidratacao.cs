using AprendendoFactoryMethod_Desafio.Product;

namespace AprendendoFactoryMethod_Desafio.ConcreteProduct
{
    public class CremeHidratacao : Creme
    {
        public override string Descricao => "Utilizado para repor a água e os nutrientes dos fios";
        public override double PrecoMinimo => 15.00;
        public override TipoCremeEnum Tipo => TipoCremeEnum.CremeHidratacao;

    }
}
