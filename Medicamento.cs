using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Final
{
    public class Medicamento
    {
        public string codigo { get; set; }
        public string ingrediente { get; set; }
        public string laboratorio { get; set; }
        List<string> enfermedades_recetado { get; set; }
    }
}