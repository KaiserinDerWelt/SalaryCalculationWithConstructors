using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculationWithConstructors
{
    class EMPLEADO
    {
      
        private double SM = 0.0; //Salario mensual x input
        private double BM = 0.0;// Bono mensual definido como constante

        //Constructor vacio
        public EMPLEADO() { }
      

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
    }
}
