using System;

namespace SalaryCalculationWithConstructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Esta es la evolucion del software de nomina");
            //Instanciacion de la clase EMPLEADO
            EMPLEADO Empleado = new EMPLEADO();
            Console.WriteLine("Bienvenido a SalarySoft");
            Console.WriteLine("Siga los pasos indicados para el calculo de su $alario Anual $$$");
            Console.WriteLine("1- Ingrese su salario mensual");
            var SalarioInputUser = Console.ReadLine();
            double SalarioParced = double.Parse(SalarioInputUser);
            //SM SALARIO MENSUAL
            var SM = SalarioParced;
            //Dot notation para acceder al atributo SALARIO de la clase Empleado
            Empleado.Salario = SM;
            var SCM = Empleado.AS(SM); //
            var SAN = Empleado.SalarioAno(SM);//
            //Imprime los resultados del calculo
            var SCB = Empleado.SalarioAno(SM,1500);
            var GUARBCOAZTECA = Empleado.AS(SM, 799);
            //mientras estamos en la clase main
            Console.WriteLine("Su salario mensual es de:" + SM);
            Console.WriteLine("Su salario mensual con guardadito por productividad es de:" + GUARBCOAZTECA);
            Console.WriteLine("Su salario con aumento extraordinario del 10% es de:" + SCM);
            Console.WriteLine("Su salario anual es de:" + SAN);
            Console.WriteLine("Su salario con bono ley es" + SCB);
        }
    }
}
