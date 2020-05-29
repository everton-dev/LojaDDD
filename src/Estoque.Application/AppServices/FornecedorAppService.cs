using AutoMapper;
using Estoque.Application.Interfaces.Application;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Estoque.Entities.Views;
using System;
using System.Collections.Generic;

namespace Estoque.Application.AppServices
{
    public class FornecedorAppService : IFornecedorApplication
    {
        private readonly IMapper _mapper;
        private readonly IFornecedorRepository _FornecedorRepository;

        public FornecedorAppService(IMapper mapper, IFornecedorRepository FornecedorRepository)
        {
            _mapper = mapper;
            _FornecedorRepository = FornecedorRepository;
        }

        public void Alterar(FornecedorView input)
        {
            var obj = _mapper.Map<Fornecedor>(input);
            _FornecedorRepository.Alterar(obj);
        }

        public void Inserir(FornecedorView input)
        {
            var obj = _mapper.Map<Fornecedor>(input);
            _FornecedorRepository.Inserir(obj);
        }

        public FornecedorView Obter(int id)
        {
            Fornecedor obj = null;

            obj = _FornecedorRepository.Obter(id);

            var result = _mapper.Map<FornecedorView>(obj);
            return result;
        }

        public IEnumerable<FornecedorView> ObterTodos()
        {
            IEnumerable<Fornecedor> obj = null;
            obj = _FornecedorRepository.ObterTodos();

            var result = _mapper.Map<IEnumerable<FornecedorView>>(obj);
            return result;
        }
    }
}