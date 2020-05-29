using AutoMapper;
using Estoque.Application.Interfaces.Application;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Estoque.Entities.Views;
using System;
using System.Collections.Generic;

namespace Estoque.Application.AppServices
{
    public class CorAppService : ICorApplication
    {
        private readonly IMapper _mapper;
        private readonly ICorRepository _CorRepository;

        public CorAppService(IMapper mapper, ICorRepository CorRepository)
        {
            _mapper = mapper;
            _CorRepository = CorRepository;
        }

        public void Alterar(CorView input)
        {
            var obj = _mapper.Map<Cor>(input);
            _CorRepository.Alterar(obj);
        }

        public void Inserir(CorView input)
        {
            var obj = _mapper.Map<Cor>(input);
            _CorRepository.Inserir(obj);
        }

        public CorView Obter(int idMarca, int idCategoria, int idSegmento, int idCor)
        {
            Cor obj = null;

            obj = _CorRepository.Obter(idMarca, idCategoria, idSegmento, idCor);

            var result = _mapper.Map<CorView>(obj);
            return result;
        }

        public CorView Obter(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CorView> ObterTodos()
        {
            IEnumerable<Cor> obj = null;
            obj = _CorRepository.ObterTodos();

            var result = _mapper.Map<IEnumerable<CorView>>(obj);
            return result;
        }

        public IEnumerable<CorView> ObterTodos(int? idMarca, int? idCategoria, int? idSegmento, int? idCor)
        {
            IEnumerable<Cor> obj = null;
            obj = _CorRepository.ObterTodos(idMarca, idCategoria, idSegmento, idCor);

            var result = _mapper.Map<IEnumerable<CorView>>(obj);
            return result;
        }
    }
}