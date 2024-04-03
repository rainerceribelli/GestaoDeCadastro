using GestaoDeCadastro.Crosscutting.Attributes;

namespace GestaoDeCadastro.Crosscutting.Enum.Cadastro
{
    public class TipoCadastroPessoa
    {
        public enum TipoCadastroPessoaEnum
        {
            [EnumInfos(Title = "Fisica")]
            Fisica = 1,

            [EnumInfos(Title = "Juridica")]
            Juridica = 2
        }

    }
}
