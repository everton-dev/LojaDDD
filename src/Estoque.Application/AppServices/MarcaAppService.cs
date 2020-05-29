using AutoMapper;
using Estoque.Application.Interfaces.Application;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Estoque.Entities.Views;
using System;
using System.Collections.Generic;

namespace Estoque.Application.AppServices
{
    public class MarcaAppService : IMarcaApplication
    {
        private readonly IMapper _mapper;
        private readonly IMarcaRepository _MarcaRepository;

        public MarcaAppService(IMapper mapper, IMarcaRepository MarcaRepository)
        {
            _mapper = mapper;
            _MarcaRepository = MarcaRepository;
        }

        public void Alterar(MarcaView input)
        {
            var obj = _mapper.Map<Marca>(input);
            _MarcaRepository.Alterar(obj);
        }

        public void Inserir(MarcaView input)
        {
            var obj = _mapper.Map<Marca>(input);
            _MarcaRepository.Inserir(obj);
        }

        public MarcaView Obter(int id)
        {
            Marca obj = null;

            obj = _MarcaRepository.Obter(id);

            var result = _mapper.Map<MarcaView>(obj);
            return result;
        }

        public IEnumerable<MarcaView> ObterTodos()
        {
            IEnumerable<Marca> obj = null;
            obj = _MarcaRepository.ObterTodos();

            var result = _mapper.Map<IEnumerable<MarcaView>>(obj);
            return result;
        }
    }
}