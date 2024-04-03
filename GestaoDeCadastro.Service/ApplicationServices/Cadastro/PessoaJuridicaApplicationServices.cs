using GestaoDeCadastro.Crosscutting.DTO.Cadastro;
using GestaoDeCadastro.Domain.Entities.Cadastro;
using GestaoDeCadastro.Infraestructure.Persistance.UnitOfWork.Cadastro;
using GestaoDeCadastro.Service.ApplicationServices.Base;

namespace GestaoDeCadastro.Service.ApplicationServices.Cadastro
{
    public class PessoaJuridicaApplicationServices : BaseApplicationServices
    {
        PessoaJuridicaUnitOfWork _uow;

        public PessoaJuridicaApplicationServices(PessoaJuridicaUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<tPessoaJuridica> CreatePessoaJuridica(CreatePessoaJuridicaDTO _CreatePessoaJuridica, bool _Comit = true)
        {
            try
            {
                tPessoaJuridica CreatePessoaJuridica = new tPessoaJuridica()
                {
                    IdPessoa = _CreatePessoaJuridica.IdPessoa,
                    CNPJ = _CreatePessoaJuridica.CNPJ,
                    RazaoSocial = _CreatePessoaJuridica.RazaoSocial,
                };

                ValidateObj(CreatePessoaJuridica);
                await _uow.PessoaJuridicaRepository.AddAsync(CreatePessoaJuridica);

                if (_Comit)
                    await _uow.CommitAsync();

                return CreatePessoaJuridica;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
