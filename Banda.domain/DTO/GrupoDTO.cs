using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Banda.domain.DTO
{
    public class GrupoDTO
    {
        public Guid Id { get; set; }
        public string Descricao { get; set; }
        public string NomeMusica {get; set;}
        public int SequenciaMusica {get; set;}
    }
}