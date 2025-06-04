using static PlanPicker.Modelos.FuncionesGlobalesEnums;

namespace PlanPicker.Modelos
{
    public class Plan
    {
        public long ID { get; set; }
        public string DESCRIPCION { get; set; }
        public PlanTypeEnum[] TIPO_PLAN { get; set; }
    }
}

