using GestaoDeCadastro.Crosscutting.DTO.Cadastro;
using GestaoDeCadastro.Domain.Entities.Cadastro;
using GestaoDeCadastro.Infraestructure.Persistance.UnitOfWork.Cadastro;
using GestaoDeCadastro.Service.ApplicationServices.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestaoDeCadastro.Service.ApplicationServices.Cadastro
{
    public class PessoaFisicaApplicationServices : BaseApplicationServices
    {
        private PessoaFisicaUnitOfWork _uow;

        public PessoaFisicaApplicationServices(PessoaFisicaUnitOfWork uow)
        {
            _uow = uow;
        }

        public async Task<tPessoaFisica> CreatePessoaFisica(CreatePessoaFisicaDTO _CreatePessoaFisica, bool _Comit = true)
        {
            try
            {
                tPessoaFisica CreatePessoaFisica = new tPessoaFisica()
                {
                    IdPessoa = _CreatePessoaFisica.IdPessoa,
                    CPF = _CreatePessoaFisica.CPF,
                };

                ValidateObj(CreatePessoaFisica);
                await _uow.PessoaFisicaRepository.AddAsync(CreatePessoaFisica);

                if(_Comit)
                    await _uow.CommitAsync();

                return CreatePessoaFisica;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
