using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor
{
    public class Operaciones
    {
        //Sobrecarga de metodos
        public double Convertir(double v)
        {
            //Metodo para la conversion de cm a metros
            double r;
            r = v / 100;
            Console.WriteLine("El resultado es " + r+" Metros");
            Console.WriteLine();
            return r;
        }
        public double Convertir(double v,double v1)
        {
            //Metodo para pasar de metros a pulgadas
            double r;
            r = v * 39.3701;
            Console.WriteLine("El resultado es " + r+" Pulgadas");
            Console.WriteLine();
            return r;
        }
        public double Convertir(double v,double v1,double v2)
        {
            //Metodo para pasar de litros a ml
            double r;
            r = v * 1000;
            Console.WriteLine("El resultado es " + r+" Mililitros");
            Console.WriteLine();
            return r;
        }
    }
}
