using System.ComponentModel.DataAnnotations;

namespace WebApplication1
{
    public class Cliente
    {
        [Key]
        public int CPF { get; set; }

        [Required, StringLength(15)]
        public string Nome { get; set; }

    }
}