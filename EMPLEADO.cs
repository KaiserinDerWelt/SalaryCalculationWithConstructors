using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculationWithConstructors
{
    class EMPLEADO
    {
      
        private double SM = 0.0; //Salario mensual x input
        private double BM = 0.0;// Bono mensual definido como constante
        private int SSN; //Social Security Number
        private string Nombre;
     
   

        //Constructor vacio debe tener mismo nombre que la clase
        public EMPLEADO() { }

        //Constructor un parametro--> SM

        public EMPLEADO(double SM): this (){
            this.SM = SM;
            Console.WriteLine("Soy un constructor y recibo UN parametro: SM");
        }

        //Constructor de dos parametros -->SSN & SM
        public EMPLEADO(int SSN, double SM) : this()
        {
            this.SM = SM;
            this.SSN = SSN;
            Console.WriteLine("Soy un constructor y recibo DOS parametro: SSN & SM");
        }

        //Constructor de tres parametros --> SM, SSN & Nombre
        public EMPLEADO(int SSN, double SM, string Nombre) : this()
        {
            this.SM = SM;
            this.SSN = SSN;
            this.Nombre = Nombre;
            Console.WriteLine("Soy un constructor y recibo TRES parametro:Nombre & SSN & SM");
        }
        // Finalizer o destructer
        ~EMPLEADO() => Console.WriteLine("Soy el finalizer y destruyo!");

        //

        //Acceso a salario
        public double Salario
        {
            
            get
            {
                return SM;
            }
            set
            {
               
                if (value < 0)
                {
                    SM = 0.0;
                }
                else
                {
                
                    SM = value;
                }
            }
        }

        // Sobrecarga de metodos SM

        // Acceso a bono mensual
        public double BonoMensual
        {
            get
            {
                return BM;
            }
            set
            {
                if (value < 0)
                {
                    BM = 0.0;
                }
                else
                {
                    BM = value;
                }
            }
        }

        //Aumento 10%
        // AS aumento salario 
        public double AS(double SalarioBasico)
        {
            if (SalarioBasico > 2500 && SalarioBasico <= 5000)
            {
                double CalculoAumento = SalarioBasico * 0.10;
                SalarioBasico = CalculoAumento + SalarioBasico;
            }
            return SalarioBasico;
        }

      

        //Salario anual

        public double SalarioAno(double salarioAnualUnoDoce)
        {
            double SalarioAno = salarioAnualUnoDoce * 12;
            salarioAnualUnoDoce = SalarioAno;
            return salarioAnualUnoDoce;
        }

        public double SalarioAno(double salarioAnualUnoDoce, double bonoLey)
        {
            double SalarioAno = (salarioAnualUnoDoce * 12) + bonoLey;
            salarioAnualUnoDoce = SalarioAno;
            return salarioAnualUnoDoce;
        }

    }
}
