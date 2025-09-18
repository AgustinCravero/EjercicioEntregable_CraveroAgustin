using ClasesEntregable.Data;
using ClasesEntregable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEntregable.Repository
{
    public class EmpleadoRepository
    {
        public static void CargarEmpleado(Empleado empleado)
        {
            using var context = new ApplicationDbContext();
            context.Empleados.Add(empleado);

            context.SaveChanges();
        }

        public static List<Empleado> ObtenerEmpleado()
        {
            using var context = new ApplicationDbContext();
            return context.Empleados.ToList();
        }
    }
}
