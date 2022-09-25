using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banda.domain.DTO;
using Banda.domain.Interfaces.Repositories;
using Banda.domain.Interfaces.Services;
using Banda.domain.Models;

namespace Banda.domain.Services
{
    public class GrupoServico : IGrupoServico
    {
        private readonly IGrupoRepositorio _grupoRepositorio;
        public GrupoServico(IGrupoRepositorio grupoRepositorio)
        {
            _grupoRepositorio = grupoRepositorio;
        }

        public void Inserir(GrupoDTO grupoDTO)
        { 
          _grupoRepositorio.Inserir(new Grupo(grupoDTO));

        }
    }
}