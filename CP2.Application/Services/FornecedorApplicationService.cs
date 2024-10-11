using CP2.Domain.Entities;
using CP2.Domain.Interfaces;
using CP2.Domain.Interfaces.Dtos;

namespace CP2.Application.Services
{
    public class FornecedorApplicationService(IFornecedorRepository repository) : IFornecedorApplicationService
    {
        private readonly IFornecedorRepository _repository = repository;

        public FornecedorEntity? DeletarDadosFornecedor(int id)
        {
            return _repository.DeletarDados(id);
        }

        public FornecedorEntity? EditarDadosFornecedor(int id, IFornecedorDto entity)
        {
            throw new NotImplementedException();
        }

        public FornecedorEntity? ObterFornecedorPorId(int id)
        {
            return _repository.ObterPorId(id);
        }

        public IEnumerable<FornecedorEntity> ObterTodosFornecedores()
        {
            throw new NotImplementedException();
        }

        public FornecedorEntity? SalvarDadosFornecedor(IFornecedorDto entity)
        {
            throw new NotImplementedException();
        }
    }
}
