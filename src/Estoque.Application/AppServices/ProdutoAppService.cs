using AutoMapper;
using Estoque.Application.Interfaces.Application;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Estoque.Entities.Views;
using System;
using System.Collections.Generic;

namespace Estoque.Application.AppServices
{
    public class ProdutoAppService : IProdutoApplication
    {
        private readonly IMapper _mapper;
        private readonly IProdutoRepository _ProdutoRepository;

        public ProdutoAppService(IMapper mapper, IProdutoRepository ProdutoRepository)
        {
            _mapper = mapper;
            _ProdutoRepository = ProdutoRepository;
        }

        public void Alterar(ProdutoView input)
        {
            var obj = _mapper.Map<Produto>(input);
            _ProdutoRepository.Alterar(obj);
        }

        public void Inserir(ProdutoView input)
        {
            var obj = _mapper.Map<Produto>(input);
            _ProdutoRepository.Inserir(obj);
        }

        public ProdutoView Obter(int id)
        {
            throw new NotImplementedException();
        }

        public ProdutoView Obter(int idMarca, int idCategoria, int idSegmento, int idCor, int idProduto)
        {
            Produto obj = null;

            obj = _ProdutoRepository.Obter(idMarca, idCategoria, idSegmento, idCor, idProduto);

            var result = _mapper.Map<ProdutoView>(obj);
            return result;
        }

        public IEnumerable<ProdutoView> ObterTodos()
        {
            IEnumerable<Produto> obj = null;
            obj = _ProdutoRepository.ObterTodos();

            var result = _mapper.Map<IEnumerable<ProdutoView>>(obj);
            return result;
        }

        public IEnumerable<ProdutoView> ObterTodos(int? idMarca, int? idCategoria, int? idSegmento, int? idCor, int? idProduto)
        {
            IEnumerable<Produto> obj = null;
            obj = _ProdutoRepository.ObterTodos(idMarca, idCategoria, idSegmento, idCor, idProduto);

            var result = _mapper.Map<IEnumerable<ProdutoView>>(obj);
            return result;
        }
    }
}