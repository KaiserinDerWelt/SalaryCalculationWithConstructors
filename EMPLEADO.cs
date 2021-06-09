using System;
using System.Collections.Generic;
using System.Text;

namespace SalaryCalculationWithConstructors
{
    class EMPLEADO
    {
        // Declaracion de atributos

        private double SM = 0.0; //Salario mensual x input
        private double BM = 0.0;// Bono mensual definido como constante

        // Procedemos con el acceso a la modificacion los datos miembro
        // mediante la utilización de las sentencias get y set

        //Acceso a salario
        public double Salario
        {
            //Descriptores de acceso
            get
            {
                return SM;
            }
            set
            {
                //Estatua SM en 0.0 si el valor input es negativo
                if (value < 0)
                {
                    SM = 0.0;
                }
                else
                {
                    // Si algo diferente pasa se toma el valor
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

        //Ahora aumentamos el salario el 10 % con un metodo
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

        //Ahora calculemos el salario anual

        public double SalarioAno(double salarioAnualUnoDoce)
        {
            double SalarioAno = salarioAnualUnoDoce * 12;
            salarioAnualUnoDoce = SalarioAno;
            return salarioAnualUnoDoce;
        }
    }
}
