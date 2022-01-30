using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace CRUD_PROGRAMA.Models
{
    public class IndicadorPrograma
    {
        [Key()]
        public int IdIndicador { get; set; }

        public string Descricao { get; set; }

        public virtual List<Programa> Programa { get; set; }

        public string UndMedida { get; set; }

        public double IndiceApuracao { get; set; }

        public double IndiceDesejado { get; set; }

        public DataType UndMedidaDataType { get; set; }
    }
}
