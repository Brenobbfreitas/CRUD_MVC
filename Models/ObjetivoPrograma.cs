using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace CRUD_PROGRAMA.Models
{
    public class ObjetivoPrograma {

        [Key()]
        public int IdObjetivo { get; set; }

        public string Descricao { get; set; }

        public int ProgramaID {get; set; }

        public virtual List<Programa> Programa { get; set; }


    }
}
