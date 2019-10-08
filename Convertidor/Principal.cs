using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Convertidor
{
    public class Principal
    {
        //creacion de metodo bienvenida
        public void Bienvenido()
        {
            Console.WriteLine("-------BIENVENIDO--AL--PROGRAMA-------  \r\n presione una tecla para comenzar");
            Console.ReadKey();
            Console.WriteLine();
            Menu();
        }

        //creacion del metodo menu
        public void Menu()
        {
            //instanciacion de la clase operaciones para utilizar sus metodos
            Operaciones op = new Operaciones();
            Console.WriteLine("Bienvenido al menu, ingrese uno de los siguientes valores segun su preferencia.");
            Console.WriteLine("1- para convertir de Centimetros a Metros");
            Console.WriteLine("2- Para convertir de Metros a Pulgadas");
            Console.WriteLine("3- Para convertir de Litros a Mililitros");
            Console.WriteLine("4- Para salir del programa");
            //creacion de la variable v donde se guardara el valor dado por el usuario
            double v;
            //creacion de la variable para el switch
            string C = Console.ReadLine();
            //creacion del switch para la seleccion de conversion
            switch(C)
            {
                //Caso uno donde se llama al metodo de la clase operaciones para convertir de centimetros a metros
                case "1":
                    Console.WriteLine("Ingrese la cantidad de centimetros");
                    v = Convert.ToDouble(Console.ReadLine());
                    op.Convertir(v);
                    Menu();
                    break;
                //Caso dos donde se llama al metodo de la clase operaciones para convertir de metros a pulgadas
                case "2":
                    Console.WriteLine("Ingrese la cantidad de Metros");
                    v = Convert.ToDouble(Console.ReadLine());
                    op.Convertir(v, 0);
                    Menu();
                    break;
                //Caso tres se llama al metodo de la clase operaciones para convertir de litros a mililitros
                case "3":
                    Console.WriteLine("Ingrese la cantidad de litros");
                    v = Convert.ToDouble(Console.ReadLine());
                    op.Convertir(v, 0, 0);
                    Menu();
                    break;
                    //Caso cuatro donde se utiliza un comando para cerrar el programa
                case "4":
                    Environment.Exit(0);
                    break;
                    //en caso de no introducir una de las opciones anteriores, se le informara al usuario de su error y se le regresara al menu
                default:
                    Console.WriteLine("Ingreso un valor invalido, volviendo al menu.");
                    Menu();
                    break;



            }
        }
    }
}
