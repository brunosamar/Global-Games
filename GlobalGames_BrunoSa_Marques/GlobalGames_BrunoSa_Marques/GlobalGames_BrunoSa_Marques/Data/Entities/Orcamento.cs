using System.ComponentModel.DataAnnotations;

namespace GlobalGames_BrunoSa_Marques.Entities.Entities
{
    public class Orcamento
    {
        public int Id { get; set; }


        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }



        [Required]
        [Display(Name = "Email")]
        public string Mail { get; set; }


        [Required]
        [Display(Name = "Mensagem")]
        public string Message { get; set; }
    }
}
