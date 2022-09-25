using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banda.domain.DTO;
using Banda.domain.Interfaces.Repositories;
using Banda.domain.Interfaces.Services;
using Banda.domain.Models;
using Banda.domain.Conversores;

namespace Banda.domain.Services
{
    public class GrupoServico : IGrupoServico
    {
        private readonly IGrupoRepositorio _grupoRepositorio;
        public Grupo grupo {get; set;} //Criei esta propriedade para ser usada no método Inserir
        public GrupoServico(IGrupoRepositorio grupoRepositorio)
        {
            _grupoRepositorio = grupoRepositorio;
        }

        public void Inserir(GrupoDTO grupoDTO)
        { 
          //_grupoRepositorio.Inserir(new Grupo(grupoDTO)); --> Esta era a versão anterior
          // onde eu mandava o DTO para dentro da model "Grupo" e lá era feita a conversão de DTO para Model.
          // Na nova versão, chamo aqui a classe "ConverterParaModel" e mando lá para ela
          // fazer essa conversão e trazer de volta na variável "grupo", já como Model.
          grupo = ConverterParaModel.ParaModel(grupoDTO);
          _grupoRepositorio.Inserir(grupo);

        }
    }
}