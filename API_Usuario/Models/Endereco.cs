using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace API_Usuario.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Pais { get; set; }
        public string Estado { get; set; }
        public string Municipio { get; set; }
        public string cep { get; set; }
        public string rua { get; set; }
        public string numero { get; set; }
        public string complemento { get; set; }

    }
}
