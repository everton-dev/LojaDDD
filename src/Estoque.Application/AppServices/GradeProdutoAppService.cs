using AutoMapper;
using Estoque.Application.Interfaces.Application;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Estoque.Entities.Views;
using System;
using System.Collections.Generic;

namespace Estoque.Application.AppServices
{
    public class GradeProdutoAppService : IGradeProdutoApplication
    {
        private readonly IMapper _mapper;
        private readonly IGradeProdutoRepository _GradeProdutoRepository;

        public GradeProdutoAppService(IMapper mapper, IGradeProdutoRepository GradeProdutoRepository)
        {
            _mapper = mapper;
            _GradeProdutoRepository = GradeProdutoRepository;
        }

        public void Alterar(GradeProdutoView input)
        {
            var obj = _mapper.Map<GradeProduto>(input);
            _GradeProdutoRepository.Alterar(obj);
        }

        public void Inserir(GradeProdutoView input)
        {
            var obj = _mapper.Map<GradeProduto>(input);
            _GradeProdutoRepository.Inserir(obj);
        }

        public GradeProdutoView Obter(int id)
        {
            throw new NotImplementedException();
        }

        public GradeProdutoView Obter(int IdMarca, int IdCategoria, int IdSegmento, int IdCor, int IdProduto, int IdProdutoItem, int IdGradeProduto)
        {
            GradeProduto obj = null;

            obj = _GradeProdutoRepository.Obter(IdMarca, IdCategoria, IdSegmento, IdCor, IdProduto, IdProdutoItem, IdGradeProduto);

            var result = _mapper.Map<GradeProdutoView>(obj);
            return result;
        }

        public IEnumerable<GradeProdutoView> ObterTodos()
        {
            IEnumerable<GradeProduto> obj = null;
            obj = _GradeProdutoRepository.ObterTodos();

            var result = _mapper.Map<IEnumerable<GradeProdutoView>>(obj);
            return result;
        }

        public IEnumerable<GradeProdutoView> ObterTodos(int? IdMarca, int? IdCategoria, int? IdSegmento, int? IdCor, int? IdProduto, int? IdProdutoItem, int? IdGradeProduto, int? IdPedido)
        {
            IEnumerable<GradeProduto> obj = null;
            obj = _GradeProdutoRepository.ObterTodos(IdMarca, IdCategoria, IdSegmento, IdCor, IdProduto, IdProdutoItem, IdGradeProduto, IdPedido);

            var result = _mapper.Map<IEnumerable<GradeProdutoView>>(obj);
            return result;
        }
    }
}