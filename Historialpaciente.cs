using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final
{
    public class Historialpaciente
    {
        public string id { get; set; }
        public string nit { get; set; }
        public string fechahora_consulta { get; set; }
        public string temperatura { get; set; }
        public string presion { get; set; }
        public List<Sintoma> sintomas { get; set; }
        public string diagnostico { get; set; }
        public string tratamiento { get; set; }
        public List <Medicamento> receta { get; set; }
        public string proxima_visista { get; set; }
        public string costo { get; set; }
        public string imagen { get; set; }
    }
}