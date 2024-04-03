namespace GestaoDeCadastro.Crosscutting.DTO.Cadastro
{
    public class PessoaDTO
    {
        public int Id { get; set; }
        public int Tipo { get; set; }

        public string TipoCadastro { get; set; }

        public string Nome { get; set; }

        public string Endereco { get; set; }

        public string Telefone { get; set; }

        public bool BitAtivo { get; set; }

        public string CPF { get; set; }

        public string CNPJ { get; set; }

        public string RazaoSocial { get; set; }
    }
}
