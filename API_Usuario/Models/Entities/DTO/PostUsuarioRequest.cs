using System.ComponentModel.DataAnnotations;

namespace API_Usuario.Models.Entities.DTO
{
    public class PostUsuarioRequest
    {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string Pis { get; set; }
        public string Senha { get; set; }
        public int EnderecoId { get; set; }
    }
}
