using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Usuario.Models
{
    [Table(name:"usuario")]
    public class Usuario
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Pis { get; set; }
        public string Senha { get; set; }
        public int EnderecoId { get; set; }

    }
}
