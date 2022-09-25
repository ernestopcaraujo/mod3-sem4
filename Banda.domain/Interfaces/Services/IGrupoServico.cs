using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banda.domain.DTO;
using Banda.domain.Models;

namespace Banda.domain.Interfaces.Services
{
    public interface IGrupoServico
    {
        void Inserir(GrupoDTO grupoDTO);
    }
}