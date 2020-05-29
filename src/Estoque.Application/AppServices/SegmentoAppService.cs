using AutoMapper;
using Estoque.Application.Interfaces.Application;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Estoque.Entities.Views;
using System;
using System.Collections.Generic;

namespace Estoque.Application.AppServices
{
    public class SegmentoAppService : ISegmentoApplication
    {
        private readonly IMapper _mapper;
        private readonly ISegmentoRepository _SegmentoRepository;

        public SegmentoAppService(IMapper mapper, ISegmentoRepository SegmentoRepository)
        {
            _mapper = mapper;
            _SegmentoRepository = SegmentoRepository;
        }

        public void Alterar(SegmentoView input)
        {
            var obj = _mapper.Map<Segmento>(input);
            _SegmentoRepository.Alterar(obj);
        }

        public void Inserir(SegmentoView input)
        {
            var obj = _mapper.Map<Segmento>(input);
            _SegmentoRepository.Inserir(obj);
        }

        public SegmentoView Obter(int id)
        {
            throw new NotImplementedException();
        }

        public SegmentoView Obter(int idMarca, int idCategoria, int idSegmento)
        {
            Segmento obj = null;

            obj = _SegmentoRepository.Obter(idMarca, idCategoria, idSegmento);

            var result = _mapper.Map<SegmentoView>(obj);
            return result;
        }

        public IEnumerable<SegmentoView> ObterTodos()
        {
            IEnumerable<Segmento> obj = null;
            obj = _SegmentoRepository.ObterTodos();

            var result = _mapper.Map<IEnumerable<SegmentoView>>(obj);
            return result;
        }

        public IEnumerable<SegmentoView> ObterTodos(int? idMarca, int? idCategoria, int? idSegmento)
        {
            IEnumerable<Segmento> obj = null;
            obj = _SegmentoRepository.ObterTodos(idMarca, idCategoria, idSegmento);

            var result = _mapper.Map<IEnumerable<SegmentoView>>(obj);
            return result;
        }
    }
}