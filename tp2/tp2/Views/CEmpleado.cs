using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace tp2.Views
{
    public class CEmpleado
    {

        public static int Anios(DateTime fecha)
        {
            DateTime FechaActual = DateTime.Today;
            if (fecha > FechaActual)
            {
                Console.WriteLine("Error al ingrsar la fecha. la fecha que ingreso aun no sucedio");
                return -1;
            }
            else
            {
                int edad = FechaActual.Year - fecha.Year;
                if (fecha.Month > FechaActual.Month || (FechaActual.Month == fecha.Month && FechaActual.Day > fecha.Day))
                {
                    edad--;
                }
                return edad;
            }
        }

        public static double Salario(int anios)
        {
            try
            {
                double SaldoBase = 5000;
                double descuento = SaldoBase * 0.15;
                double adicional = (anios * SaldoBase)/100;

                return SaldoBase + adicional - descuento;
            }
            catch (Exception)
            {
                return -1;
            }

        }

        
    }
}
