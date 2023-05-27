namespace Laboratorio
{
    class Program
    {
        static void Main(string[] args)
        {

            GestorEmpleados gestor = new GestorEmpleados("ruta_de_tu_base_de_datos");


            gestor.CrearTabla();

            
            Empleado empleado1 = new Empleado(1, "Juan", "Pérez", 30, "Gerente");
             Empleado empleado2 = new Empleado(2, "Jose", "Paíz", 25, "Asistente");
             Empleado empleado3 = new Empleado(3, "Obed", "Alay", 20, "Secretario");
             Empleado empleado4 = new Empleado(4, "Carlos", "Medina", 24, "Tesorero");
             Empleado empleado5 = new Empleado(5, "Mynor", "Ruano", 21, "Bodeguero");

             gestor.AgregarEmpleado(empleado1);
             gestor.AgregarEmpleado(empleado4);
             gestor.AgregarEmpleado(empleado5);


             var empleados = gestor.ObtenerEmpleados();


             Console.WriteLine("Empleados:");
             foreach (var empleado in empleados)
             {
                 Console.WriteLine(empleado.ToString());
             }

             Console.ReadLine();

            gestor.ObtenerEmpleados().ForEach(e => Console.WriteLine(e.Nombre));
            Console.ReadLine();
        }
        
    }
}



