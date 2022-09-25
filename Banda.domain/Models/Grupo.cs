using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Banda.domain.DTO;

namespace Banda.domain.Models
{
    public class Grupo
    {
        public Guid Id {get; set;} = Guid.NewGuid();
        public string Descricao { get; set; }
        public string NomeMusica {get; set;}
        public int SequenciaMusica {get; set;}

        
        public Grupo(GrupoDTO  grupoDTO)
        {
            Id = grupoDTO.Id;
            Descricao = grupoDTO.Descricao;
            NomeMusica = grupoDTO.NomeMusica;
            SequenciaMusica = grupoDTO.SequenciaMusica;
        }

        public Grupo()
        {

        }
    }

}