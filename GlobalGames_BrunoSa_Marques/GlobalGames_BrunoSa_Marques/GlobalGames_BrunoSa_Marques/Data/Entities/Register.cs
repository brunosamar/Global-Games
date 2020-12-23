using System;
using System.ComponentModel.DataAnnotations;

namespace GlobalGames_BrunoSa_Marques.Data.Entities
{
    public class Register
    {
        public int Id { get; set; }


        [Required]
        [Display(Name = "Nome")]
        public string Name { get; set; }

        [Required]
        [Display(Name = "Apelido")]
        public string Surname { get; set; }


        [Required]
        [Display(Name = "Morada")]
        public string Address { get; set; }


        [Required]
        [Display(Name = "Localidade")]
        public string City { get; set; }


        [Required] /* neste campo por agora pode ser uma string, mas consoante a configuração exigida pode haver a necessidade de especificar o campo para numerico com máximo permitido */
        [Display(Name = "CC")]
        public string CC { get; set; }


        [Required]
        [Display(Name = "Data de Nascimento")]
        public DateTime Birth { get; set; }

    }
}


