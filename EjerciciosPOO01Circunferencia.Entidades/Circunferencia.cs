using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosPOO01Circunferencia.Entidades
{
    public class Circunferencia
    {
        //Atributos
        private int Radio;

        //Propiedades
        public void SetRadio(int value)
        {
            if (value > 0)
            {
                Radio = value;
            }
            else
            {
                throw new Exception("Valor del radio incorrecto!!!!");
            }
        }

        public int GetRadio()
        {
            return Radio;
        }
        //Constructor
        public Circunferencia()
        {
            
        }

        //Métodos

        public double GetPerimetro()
        {
            return 2 * Math.PI * Radio;
        }

        public double GetSuperficie()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
    }
}
