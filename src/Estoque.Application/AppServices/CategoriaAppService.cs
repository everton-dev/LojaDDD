using AutoMapper;
using Estoque.Application.Interfaces.Application;
using Estoque.Domain.Interfaces.Repository;
using Estoque.Domain.Models;
using Estoque.Entities.Views;
using System;
using System.Collections.Generic;

namespace Estoque.Application.AppServices
{
    public class CategoriaAppService : ICategoriaApplication
    {
        private readonly IMapper _mapper;
        private readonly ICategoriaRepository _categoriaRepository;

        public CategoriaAppService(IMapper mapper, ICategoriaRepository categoriaRepository)
        {
            _mapper = mapper;
            _categoriaRepository = categoriaRepository;
        }

        public void Alterar(CategoriaView input)
        {
            var obj = _mapper.Map<Categoria>(input);
            _categoriaRepository.Alterar(obj);
        }

        public void Inserir(CategoriaView input)
        {
            var obj = _mapper.Map<Categoria>(input);
            _categoriaRepository.Inserir(obj);
        }

        public CategoriaView Obter(int idMarca, int idCategoria)
        {
            Categoria obj = null;

            obj = _categoriaRepository.Obter(idMarca, idCategoria);

            var result = _mapper.Map<CategoriaView>(obj);
            return result;
        }

        public CategoriaView Obter(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoriaView> ObterTodos(int? idMarca, int? idCategoria)
        {
            IEnumerable<Categoria> obj = null;
            obj = _categoriaRepository.ObterTodos(idMarca, idCategoria);

            var result = _mapper.Map<IEnumerable<CategoriaView>>(obj);
            return result;
        }

        public IEnumerable<CategoriaView> ObterTodos()
        {
            IEnumerable<Categoria> obj = null;
            obj = _categoriaRepository.ObterTodos();

            var result = _mapper.Map<IEnumerable<CategoriaView>>(obj);
            return result;
        }
    }
}