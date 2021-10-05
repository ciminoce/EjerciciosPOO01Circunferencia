using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EjerciciosPOO01Circunferencia.Entidades;

namespace EjerciciosPOO01Circunferencia.Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Circunferencia c = new Circunferencia();//creo un obj de tipo Circunferencia
                c.SetRadio(10);
                Console.WriteLine($"Circ de radio {c.GetRadio()}");
                Console.WriteLine($"Su perímetro es {c.GetPerimetro()}");
                Console.WriteLine($"Su superficie es {c.GetSuperficie()}");
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            } 
            Console.ReadLine();
        }
    }
}
