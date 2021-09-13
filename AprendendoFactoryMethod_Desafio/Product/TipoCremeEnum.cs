using System.ComponentModel.DataAnnotations;

namespace AprendendoFactoryMethod_Desafio.Product
{
    public enum TipoCremeEnum
    {
        [Display(Name = "Creme de Pentear")]
        CremePentear = 1,

        [Display(Name = "Creme de Hidratação")]
        CremeHidratacao = 2,

        [Display(Name = "Condicionador")]
        Condicionador = 3,

        [Display(Name = "Shampoo")]
        Shampoo = 4
    }
}
