using ClasesEntregable.Models;
using ClasesEntregable.Repository;

internal class Program
{
        static void Main(string[] args)
        {
        List<Empleado> empleados = EmpleadoRepository.ObtenerEmpleado();
        List<Departamento> departamentos = DepartamentoRepository.ObtenerDepartamento();
        while (true)
            {
                Console.Clear();
                Console.WriteLine("Menú");
                Console.WriteLine();
                Console.WriteLine("1- Registrar nuevo empleado");
                Console.WriteLine("2- Actualizar salario de empleado");
                Console.WriteLine("3- Eliminar empleado");
                Console.WriteLine("4- Registrar nuevo departamento");
                Console.WriteLine("5- Estadísticas de empleados");
                Console.WriteLine("6- Salir");
                Console.WriteLine();
                Console.WriteLine("Ingrese el número correspondiente a la opción");
                string opcion = Console.ReadLine().Trim();
                switch (opcion)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Ingrese el nombre del empleado: ");
                        string nombre = Console.ReadLine();
                        Console.WriteLine("Email: ");
                        string email = Console.ReadLine();
                        if (empleados.Exists(e => e.email == email))
                        {
                            Console.WriteLine("El email ya esta registrado para un empleado");
                            break;
                        }
                        Console.WriteLine("Ingrese el salario del empleado: ");
                        decimal salario = decimal.Parse(Console.ReadLine());
                        Console.WriteLine("Departamentos disponibles:");
                        foreach (var dept in departamentos)
                        {
                            Console.WriteLine($"Id: {dept.id}, Nombre: {dept.nombre}");
                        }
                        Console.WriteLine("Ingrese el Id del departamento: ");
                        int departamentoID = int.Parse(Console.ReadLine());
                        if (!departamentos.Exists(d => d.id == departamentoID))
                        {
                            Console.WriteLine("El Id ingresado no existe.");
                            break;
                        }
                        Empleado empleado = new Empleado() 
                        {   
                            nombre = nombre, 
                            email = email, 
                            salario = salario, 
                            DepartamentoId = departamentoID 
                        };
                        empleados.Add(empleado);
                        EmpleadoRepository.CargarEmpleado(empleado);
                        Console.WriteLine("Empleado registrado.");
                        Console.ReadKey(true);
                        break;
                    case "2":
                        Console.Clear();
                        Console.Write("Ingrese el email del empleado: ");
                        string emailActSalario = Console.ReadLine();
                        Empleado empleadoActSalario = empleados.FirstOrDefault(e => e.email == emailActSalario);
                        if (empleadoActSalario == null)
                        {
                            Console.WriteLine("Empleado no encontrado.");
                        }
                        else
                        {
                            Console.WriteLine("Ingrese el nuevo salario: ");
                            empleadoActSalario.salario = decimal.Parse(Console.ReadLine());
                            Console.WriteLine("Salario actualizado.");
                        }
                        Console.ReadKey(true);
                        break;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Ingrese el email del empleado que desea eliminar: ");
                        string emailEliminar = Console.ReadLine();
                        Empleado empleadoEliminar = empleados.FirstOrDefault(e => e.email == emailEliminar);
                        if (empleadoEliminar == null)
                        {
                            Console.WriteLine("Empleado no encontrado.");
                        }
                        else
                        {
                            empleados.Remove(empleadoEliminar);
                            Console.WriteLine("Empleado eliminado.");
                        }
                        Console.ReadKey(true);
                        break;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Registrar nuevo departamento");
                        Console.WriteLine("Ingrese el nombre del departamento: ");
                        string nombreDepartamento = Console.ReadLine();
                        Console.WriteLine("Ingrese la descripción del departamento: ");
                        string descripcionDepartamento = Console.ReadLine();
                        Departamento departamento = new Departamento() { nombre = nombreDepartamento, descripcion = descripcionDepartamento };
                        departamentos.Add(departamento);
                        DepartamentoRepository.CargarDepartamento(departamento);
                        Console.ReadKey(true);
                        break;
                    case "5":
                        Console.Clear();
                        Console.WriteLine("Estadísticas de empleados");
                        int totalEmpleados = empleados.Count;
                        if (totalEmpleados == 0)
                        {
                            Console.WriteLine("No hay empleados registrados por el momento.");
                            break;
                        }
                        else
                        {
                            decimal salarioPromedio = empleados.Average(e => e.salario);
                            Console.WriteLine($"Total de empleados: {totalEmpleados}");
                            Console.WriteLine($"Salario promedio: {salarioPromedio}");
                            Console.ReadKey(true);
                            break;
                        }
                    case "6":
                        break;
                    default:
                        Console.WriteLine("Opción inválida");
                        Console.ReadKey(true);
                        break;
                }
                if (opcion == "6") break;
            }
        }
    }

