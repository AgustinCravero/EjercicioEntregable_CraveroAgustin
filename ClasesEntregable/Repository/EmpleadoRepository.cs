using ClasesEntregable.Data;
using ClasesEntregable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

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
            return context.Empleados
                .Include(e => e.Departamento)
                .ToList();
        }
        public static void ActualizarSalario(Empleado empleado, decimal nuevoSalario)
        {
            using var context = new ApplicationDbContext();
            var empleadoDb = context.Empleados.FirstOrDefault(e => e.id == empleado.id);
            if (empleadoDb != null)
            {
                empleadoDb.salario = nuevoSalario;
                context.SaveChanges();
            }
        }
        public static void EliminarEmpleado (Empleado empleado)
        {
            using var context = new ApplicationDbContext();
            context.Empleados.Remove(empleado);
            context.SaveChanges();
        }
    }
}
