using static PlanazosPicker.Modelos.FuncionesGlobalesEnums;

namespace PlanazosPicker.Modelos
{
    public class Plan
    {
        public long ID { get; set; }
        public string DESCRIPCION { get; set; }
        public TipoPlanEnum[] TIPO_PLAN { get; set; }
    }
}

