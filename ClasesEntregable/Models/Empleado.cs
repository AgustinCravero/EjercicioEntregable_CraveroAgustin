using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEntregable.Models
{
    public class Empleado
    {
        public int id { get; set; }
        public string nombre { get; set; }
        public string email { get; set; }
        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
        public decimal salario { get; set; }
    }
}
