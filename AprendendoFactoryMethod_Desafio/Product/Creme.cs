namespace AprendendoFactoryMethod_Desafio.Product
{
    public abstract class Creme
    {
        public abstract string Descricao { get; }
        public abstract double PrecoMinimo { get; }
        public abstract TipoCremeEnum Tipo { get; }
    }
}
