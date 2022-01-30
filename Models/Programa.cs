using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace CRUD_PROGRAMA.Models
{
    [Table("Programa")]
    public class Programa
    {
        [Key()]
        public int Codigo{ get; set; }

        public string Descricao { get; set; }

        public string PublicoAlvo{ get; set; }

        public int Tipo { get; set; }

        [ForeignKey("Marco_Objetivo")]
        public int MacroObjetivo { get; set; }
        public virtual List<ObjetivoPrograma> ObjetivoPrograma { get; set; }


        public int ObjMilenio{ get; set; }

    }

  
}
