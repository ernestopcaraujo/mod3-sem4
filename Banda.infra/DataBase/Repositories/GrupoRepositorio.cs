using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banda.domain.Interfaces.Repositories;
using Banda.domain.Models;

namespace Banda.infra.DataBase.Repositories
{
    public class GrupoRepositorio : IGrupoRepositorio
    {
        private readonly GrupoDBContexto _contexto;
        public GrupoRepositorio(GrupoDBContexto contexto)
        {
            _contexto = contexto;
        }

        public void Inserir(Grupo grupo)
        {
            _contexto.Grupos.Add(grupo);
            _contexto.SaveChanges();
        }
        
    }
}