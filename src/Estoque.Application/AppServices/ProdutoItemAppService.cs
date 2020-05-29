using AutoMapper;
using Estoque.Application.Interfaces.Application;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Estoque.Entities.Views;
using System;
using System.Collections.Generic;

namespace Estoque.Application.AppServices
{
    public class ProdutoItemAppService : IProdutoItemApplication
    {
        private readonly IMapper _mapper;
        private readonly IProdutoItemRepository _ProdutoItemRepository;

        public ProdutoItemAppService(IMapper mapper, IProdutoItemRepository ProdutoItemRepository)
        {
            _mapper = mapper;
            _ProdutoItemRepository = ProdutoItemRepository;
        }

        public void Alterar(ProdutoItemView input)
        {
            var obj = _mapper.Map<ProdutoItem>(input);
            _ProdutoItemRepository.Alterar(obj);
        }

        public void Inserir(ProdutoItemView input)
        {
            var obj = _mapper.Map<ProdutoItem>(input);
            _ProdutoItemRepository.Inserir(obj);
        }

        public ProdutoItemView Obter(int id)
        {
            throw new NotImplementedException();
        }

        public ProdutoItemView Obter(int idMarca, int idCategoria, int idSegmento, int idCor, int idProduto, int idProdutoItem)
        {
            ProdutoItem obj = null;

            obj = _ProdutoItemRepository.Obter(idMarca, idCategoria, idSegmento, idCor, idProduto, idProdutoItem);

            var result = _mapper.Map<ProdutoItemView>(obj);
            return result;
        }

        public IEnumerable<ProdutoItemView> ObterTodos()
        {
            IEnumerable<ProdutoItem> obj = null;
            obj = _ProdutoItemRepository.ObterTodos();

            var result = _mapper.Map<IEnumerable<ProdutoItemView>>(obj);
            return result;
        }

        public IEnumerable<ProdutoItemView> ObterTodos(int? idMarca, int? idCategoria, int? idSegmento, int? idCor, int? idProduto, int? idProdutoItem)
        {
            IEnumerable<ProdutoItem> obj = null;
            obj = _ProdutoItemRepository.ObterTodos(idMarca, idCategoria, idSegmento, idCor, idProduto, idProdutoItem);

            var result = _mapper.Map<IEnumerable<ProdutoItemView>>(obj);
            return result;
        }
    }
}