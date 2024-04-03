namespace GestaoDeCadastro.Crosscutting.DTO.Cadastro
{
    public class CreatePessoaJuridicaDTO
    {
        public int IdPessoa { get; set; }

        public string CNPJ { get; set; }

        public string RazaoSocial { get; set; }
    }
}
