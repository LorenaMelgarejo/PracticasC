using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Clase_10;
using clas10;

namespace Clase_10
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Persona> persona= new List<Persona>();

             Alumno al = new Alumno(" santy", "lopez", 301456987);
             Alumno al2= new Alumno("luk", "gualpa",30589321);
             Alumno al3= new Alumno("mik","legui", 32489651);
             Obrero  ob = new Obrero("juan","Perez", 27852369);
             Obrero  ob2= new Obrero("ramon", "gomez",28964712);
             Obrero  ob3= new Obrero("luis", "torres",26412753);


            persona.Add(al);
            persona.Add(al2);
            persona.Add(al3);
            persona.Add(ob);
            persona.Add(ob2);
            persona.Add(ob3);

            foreach (Persona p in persona)
            {
                //if (p is Alumno)
                //{
                //    Console.WriteLine(((Alumno)p).Mostrar());


                //}
                if (p is Persona)
                {
                    Console.WriteLine(((Persona)p).Mostrar());


                }
                
            }
            Console.ReadLine();
            Console.ReadKey();
        }
    }
}
