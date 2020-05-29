using AutoMapper;
using Estoque.Application.Interfaces.Application;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Estoque.Entities.Views;
using System;
using System.Collections.Generic;

namespace Estoque.Application.AppServices
{
    public class PedidoAppService : IPedidoApplication
    {
        private readonly IMapper _mapper;
        private readonly IPedidoRepository _PedidoRepository;

        public PedidoAppService(IMapper mapper, IPedidoRepository PedidoRepository)
        {
            _mapper = mapper;
            _PedidoRepository = PedidoRepository;
        }

        public void Alterar(PedidoView input)
        {
            var obj = _mapper.Map<Pedido>(input);
            _PedidoRepository.Alterar(obj);
        }

        public void Inserir(PedidoView input)
        {
            var obj = _mapper.Map<Pedido>(input);
            _PedidoRepository.Inserir(obj);
        }

        public PedidoView Obter(int id)
        {
            Pedido obj = null;

            obj = _PedidoRepository.Obter(id);

            var result = _mapper.Map<PedidoView>(obj);
            return result;
        }

        public IEnumerable<PedidoView> ObterTodos()
        {
            IEnumerable<Pedido> obj = null;
            obj = _PedidoRepository.ObterTodos();

            var result = _mapper.Map<IEnumerable<PedidoView>>(obj);
            return result;
        }
    }
}