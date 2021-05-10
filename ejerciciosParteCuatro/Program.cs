using System;

namespace ejerciciosParteCuatro
{
    class Program
    {

        class Empleado
        {
            public string nombre;
            public string apellido;
            public string puesto;
            public double jornalPorHora;
            public int horasTrabajadas;
            public double importe;
            public double impuestoIps;

            public Empleado(string nombre, string apellido, string puesto, double jornalPorHora, int horasTrabajadas)
            {
                this.nombre = nombre;
                this.apellido = apellido;
                this.puesto = puesto;
                this.jornalPorHora = jornalPorHora;
                this.horasTrabajadas = horasTrabajadas;
            }

            public void calcular()
            {
                calcularImporte();
                calcularImpuesto();
            }

            public void calcularImporte()
            { 
                double importe = this.jornalPorHora * this.horasTrabajadas;

                this.importe = importe;
            }

            public void calcularImpuesto()
            {
                double impuesto = this.importe * 0.09;

                this.impuestoIps = impuesto;
            }

            public void generarReporte()
            {
                string impuestoFormateado = string.Format("{0:#,##0.##}", this.importe);
                string impuestoIpsFormateado = string.Format("{0:#,##0.##}", this.impuestoIps);
                double importeConIps = this.importe - this.impuestoIps;
                string importeConIpsFormateado = string.Format("{0:#,##0.##}", importeConIps);

                Console.WriteLine("            DETALLE DE EL/LA EMPLEADO/A            ");
                Console.WriteLine("===================================================");
                Console.WriteLine("  Nombre:                 {0}", this.nombre);
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("  Apellido:               {0}", this.apellido);
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("  Puesto:                 {0}", this.puesto);
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("  Importe:                {0} GS", impuestoFormateado);
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("  Impuesto IPS:           {0} GS", impuestoIpsFormateado);
                Console.WriteLine("---------------------------------------------------");
                Console.WriteLine("  Importe con dcto. IPS:  {0} GS", importeConIpsFormateado);
                Console.WriteLine("===================================================");
            }
        }

        static void Main(string[] args)
        {

            Empleado[] empleados = new Empleado[4];

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Ingrese los datos de el/la empleado/a N° {0}", i + 1);
                Console.Write("Ingrese el nombre de el/la empleado/a: ");
                string nombreEmpleado = Console.ReadLine();
                Console.Write("Ingrese el apellido de el/la empleado/a: ");
                string apellidoEmpleado = Console.ReadLine();
                Console.Write("Ingrese el puesto de el/la empleado/a: ");
                string puestoEmpleado = Console.ReadLine();
                Console.Write("Ingrese el jornal por hora de el/la empleado/a: ");
                double jornalPorHora = Convert.ToDouble(Console.ReadLine());
                Console.Write("Ingrese las horas trabajadas de el/la empleado/a: ");
                int horasTrabajadas = Convert.ToInt32(Console.ReadLine());

                Empleado empleado = new Empleado(nombreEmpleado, apellidoEmpleado, puestoEmpleado, jornalPorHora, horasTrabajadas);

                empleados[i] = empleado;
            }

            Console.WriteLine("===================================================");

            foreach (Empleado empleado in empleados)
            {
                empleado.calcular();
                empleado.generarReporte();
            }
        }
    }
}
