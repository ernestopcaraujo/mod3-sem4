using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banda.domain.Models;
using Banda.domain.DTO;

namespace Banda.domain.Interfaces.Repositories
{
    public interface IGrupoRepositorio
    {
        void Inserir(Grupo grupo);
    }
}