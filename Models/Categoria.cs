using System.ComponentModel.DataAnnotations;

namespace projeto.Models
{
    public class Categoria
    {
        public int CategoriaId{get; set;}
        [Display(Name ="Nome da Categoria")]
        public string Nome{get;set;}

    }
}