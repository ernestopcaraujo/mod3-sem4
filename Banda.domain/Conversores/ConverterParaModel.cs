using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banda.domain.DTO;
using Banda.domain.Models;

namespace Banda.domain.Conversores
{
    public static class ConverterParaModel
    {
        public static Grupo ParaModel(GrupoDTO grupoDTO)
        {
            return new Grupo 
            {
                Id = grupoDTO.Id,
                Descricao = grupoDTO.Descricao,
                NomeMusica = grupoDTO.NomeMusica,
                SequenciaMusica = grupoDTO.SequenciaMusica,
            };
        }
    }
}