using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clas10;

namespace clas10
{
     public class Obrero: Persona
    {
        //private string _nombre;
        //private string _apellido;
      //  private int _dni;
        private int _legajo;
        private float _sueldo;

        public Obrero(string nombre, string apellido, int dni)
            : base(nombre, apellido, dni)
        { }
            
        


        public Obrero(string nombre, string apellido, int dni, int legajo, float sueldo)
            : this(nombre, apellido, dni)
        {
            this._legajo = legajo;
            this._sueldo = sueldo;
        }


        public static string Mostrar(Obrero ob)// cuando es static no se utliza this y tampoco base , se lo llama x el nombre de la clase
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("nombre: " + ob._nombre);
            sb.AppendLine("apellido: " + ob._apellido);
            sb.AppendLine("Dni: " + ob._dni);

            return sb.ToString();
        }

    }
}
