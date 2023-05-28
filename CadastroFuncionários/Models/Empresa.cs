using System.ComponentModel.DataAnnotations;

namespace CadastroFuncionários.Models
{
    public class Empresa
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O CNPJ é obrigatório.")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "A Razão Social é obrigatória.")]
        public string RazaoSocial { get; set; }

        [Required(ErrorMessage = "O Nome Fantasia é obrigatório.")]
        public string NomeFantasia { get; set; }
    }
}
