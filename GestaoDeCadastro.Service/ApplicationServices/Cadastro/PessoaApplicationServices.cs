using GestaoDeCadastro.Crosscutting.DTO.Cadastro;
using GestaoDeCadastro.Domain.Entities.Cadastro;
using GestaoDeCadastro.Infraestructure.Persistance.UnitOfWork.Cadastro;
using GestaoDeCadastro.Service.ApplicationServices.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static GestaoDeCadastro.Crosscutting.Enum.Cadastro.TipoCadastroPessoa;

namespace GestaoDeCadastro.Service.ApplicationServices.Cadastro
{
    public class PessoaApplicationServices : BaseApplicationServices
    {
        private PessoaUnitOfWork _uow;
        private PessoaFisicaApplicationServices _pessoaFisicaApplicationServices;
        private PessoaJuridicaApplicationServices _pessoaJuridicaApplicationServices;

        public PessoaApplicationServices(PessoaUnitOfWork uow, 
            PessoaFisicaApplicationServices pessoaFisicaApplicationServices, 
            PessoaJuridicaApplicationServices pessoaJuridicaApplicationServices)
        {
            _uow = uow;
            _pessoaFisicaApplicationServices = pessoaFisicaApplicationServices;
            _pessoaJuridicaApplicationServices = pessoaJuridicaApplicationServices;
        }

        private IQueryable<PessoaDTO> GetQueryPessoa()
        {
            IQueryable<tPessoa> Pessoa = _uow.PessoaRepository.GetAll();
            IQueryable<tPessoaFisica> PessoaFisica = _uow.PessoaFisicaRepository.GetAll();
            IQueryable<tPessoaJuridica> PessoaJuridica = _uow.PessoaJuridicaRepository.GetAll();

            IQueryable<PessoaDTO> query = (from pessoa in Pessoa
                                           join pessoaFisica in PessoaFisica on pessoa.Id equals pessoaFisica.IdPessoa into pessoaFisicaJoin
                                           from pessoaFisicaLeft in pessoaFisicaJoin.DefaultIfEmpty() //left join
                                           join pessoaJuridica in PessoaJuridica on pessoa.Id equals pessoaJuridica.IdPessoa into pessoaJuridicaJoin
                                           from pessoaJuridicaLeft in pessoaJuridicaJoin.DefaultIfEmpty() //left join
                                           select new PessoaDTO()
                                                 {
                                                     Id = pessoa.Id,
                                                     Tipo = pessoa.Tipo,
                                                     TipoCadastro = pessoa.Tipo == (int)TipoCadastroPessoaEnum.Fisica ? "Física" :
                                                            pessoa.Tipo == (int)TipoCadastroPessoaEnum.Juridica ? "Jurídica"
                                                            : "Erro",
                                                     Nome = pessoa.Nome,
                                                     Endereco = pessoa.Endereco,
                                                     Telefone = pessoa.Telefone,
                                                     BitAtivo = pessoa.BitAtivo,
                                                     CPF = pessoaFisicaLeft.CPF,
                                                     CNPJ = pessoaJuridicaLeft.CNPJ,
                                                     RazaoSocial = pessoaJuridicaLeft.RazaoSocial
                                           });
            return query;
        }

        public async Task<List<PessoaDTO>> GetListPessoas()
        {
            try
            {
                List<PessoaDTO> Pessoas = await GetQueryPessoa().ToListAsync();

                return Pessoas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task<List<PessoaDTO>> GetListPessoasByTipo(int _Tipo)
        {
            try
            {
                if (_Tipo != (int) TipoCadastroPessoaEnum.Fisica && _Tipo != (int)TipoCadastroPessoaEnum.Juridica)
                    throw new Exception("Informe um tipo de cadastro valido!");

                List<PessoaDTO> Pessoas = await GetQueryPessoa().Where(x => x.Tipo == _Tipo).ToListAsync();

                return Pessoas;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        public async Task CreatePessoa(CreatePessoaDTO NovaPessoa)
        {
            try
            {
                ValidaPessoa(NovaPessoa);

                tPessoa CreatePessoa = new tPessoa()
                {
                    Tipo = NovaPessoa.Tipo,
                    Nome = NovaPessoa.Nome,
                    Endereco = NovaPessoa.Endereco,
                    Telefone = NovaPessoa.Telefone,
                    BitAtivo = true
                };

                if (NovaPessoa.Tipo == (int)TipoCadastroPessoaEnum.Fisica)
                    await InsereDadosPessoaFisica(CreatePessoa, NovaPessoa);

                if (NovaPessoa.Tipo == (int)TipoCadastroPessoaEnum.Juridica)
                    await InsereDadosPessoaJuridica(CreatePessoa, NovaPessoa);

                ValidateObj(CreatePessoa);
                await _uow.PessoaRepository.AddAsync(CreatePessoa);

                await _uow.CommitAsync();
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async Task InsereDadosPessoaFisica(tPessoa CreatePessoa, CreatePessoaDTO NovaPessoa)
        {
            try
            {
                List<tPessoaFisica> PessoaFisica = new List<tPessoaFisica>();

                CreatePessoaFisicaDTO CreatePessoaFisica = new CreatePessoaFisicaDTO()
                {
                    IdPessoa = CreatePessoa.Id,
                    CPF = NovaPessoa.CPF,
                };

                PessoaFisica.Add(await _pessoaFisicaApplicationServices.CreatePessoaFisica(CreatePessoaFisica));

                CreatePessoa.PessoaFisica = PessoaFisica;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private async Task InsereDadosPessoaJuridica(tPessoa CreatePessoa, CreatePessoaDTO NovaPessoa)
        {
            try
            {
                List<tPessoaJuridica> PessoaJuridica = new List<tPessoaJuridica>();

                CreatePessoaJuridicaDTO CreatePessoaJuridica = new CreatePessoaJuridicaDTO()
                {
                    IdPessoa = CreatePessoa.Id,
                    CNPJ = NovaPessoa.CNPJ,
                    RazaoSocial = NovaPessoa.RazaoSocial
                };

                PessoaJuridica.Add(await _pessoaJuridicaApplicationServices.CreatePessoaJuridica(CreatePessoaJuridica, false));

                CreatePessoa.PessoaJuridica = PessoaJuridica;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }

        private void ValidaPessoa(CreatePessoaDTO _NovaPessoa)
        {
            try
            {
                if (_NovaPessoa.Tipo != 1 && _NovaPessoa.Tipo != 2)
                    throw new Exception("Selecione um tipo de cadastro valido!");

                if (_NovaPessoa.Nome == null)
                    throw new Exception("Nome deve ser informado!");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
