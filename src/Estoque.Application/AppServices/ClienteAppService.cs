using AutoMapper;
using Estoque.Application.Interfaces.Application;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Estoque.Entities.Views;
using System;
using System.Collections.Generic;

namespace Estoque.Application.AppServices
{
    public class ClienteAppService : IClienteApplication
    {
        private readonly IMapper _mapper;
        private readonly IClienteRepository _ClienteRepository;

        public ClienteAppService(IMapper mapper, IClienteRepository ClienteRepository)
        {
            _mapper = mapper;
            _ClienteRepository = ClienteRepository;
        }

        public void Alterar(ClienteView input)
        {
            var obj = _mapper.Map<Cliente>(input);
            _ClienteRepository.Alterar(obj);
        }

        public void Inserir(ClienteView input)
        {
            var obj = _mapper.Map<Cliente>(input);
            _ClienteRepository.Inserir(obj);
        }

        public ClienteView Obter(int id)
        {
            Cliente obj = null;

            obj = _ClienteRepository.Obter(id);

            var result = _mapper.Map<ClienteView>(obj);
            return result;
        }

        public IEnumerable<ClienteView> ObterTodos()
        {
            IEnumerable<Cliente> obj = null;
            obj = _ClienteRepository.ObterTodos();

            var result = _mapper.Map<IEnumerable<ClienteView>>(obj);
            return result;
        }
    }
}