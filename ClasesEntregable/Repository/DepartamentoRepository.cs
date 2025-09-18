using ClasesEntregable.Data;
using ClasesEntregable.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesEntregable.Repository
{
    public class DepartamentoRepository
    {
        public static void CargarDepartamento(Departamento departamento)
        {
            using var context = new ApplicationDbContext();
            context.Departamentos.Add(departamento);

            context.SaveChanges();
        }

        public static List<Departamento> ObtenerDepartamento()
        {
            using var context = new ApplicationDbContext();
            return context.Departamentos.ToList();
        }
    }
}
