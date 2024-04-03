using System.ComponentModel.DataAnnotations;

namespace GestaoDeCadastro.Domain.Entities.Cadastro
{
    public class tPessoaJuridica
    {
        [Key]
        public int IdPessoaJuridica { get; set; }

        [Required]
        public int IdPessoa { get; set; }

        [Required(ErrorMessage = "Informar o CNPJ!")]
        public string CNPJ { get; set; }

        [Required(ErrorMessage = "Informar Razão Social!")]
        public string RazaoSocial { get; set; }
    }
}
