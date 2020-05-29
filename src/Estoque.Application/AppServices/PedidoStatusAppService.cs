using AutoMapper;
using Estoque.Application.Interfaces.Application;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Estoque.Entities.Views;
using System;
using System.Collections.Generic;

namespace Estoque.Application.AppServices
{
    public class PedidoStatusAppService : IPedidoStatusApplication
    {
        private readonly IMapper _mapper;
        private readonly IPedidoStatusRepository _PedidoStatusRepository;

        public PedidoStatusAppService(IMapper mapper, IPedidoStatusRepository PedidoStatusRepository)
        {
            _mapper = mapper;
            _PedidoStatusRepository = PedidoStatusRepository;
        }

        public void Alterar(PedidoStatusView input)
        {
            var obj = _mapper.Map<PedidoStatus>(input);
            _PedidoStatusRepository.Alterar(obj);
        }

        public void Inserir(PedidoStatusView input)
        {
            var obj = _mapper.Map<PedidoStatus>(input);
            _PedidoStatusRepository.Inserir(obj);
        }

        public PedidoStatusView Obter(int id)
        {
            PedidoStatus obj = null;

            obj = _PedidoStatusRepository.Obter(id);

            var result = _mapper.Map<PedidoStatusView>(obj);
            return result;
        }

        public IEnumerable<PedidoStatusView> ObterTodos()
        {
            IEnumerable<PedidoStatus> obj = null;
            obj = _PedidoStatusRepository.ObterTodos();

            var result = _mapper.Map<IEnumerable<PedidoStatusView>>(obj);
            return result;
        }
    }
}