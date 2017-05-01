using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clas10;


namespace clas10
{
    public class Persona
    {
        protected string _nombre;// es privado pero para las hijas q heredan se comporta como publico
        protected string _apellido;//private string _apellido;
        protected int _dni;



        public Persona(string nombre, string apellido, int dni)
        {
            this._nombre = nombre;
            this._apellido = apellido;
            this._dni = dni;

            //this._humano= new List<Persona>();
        }

        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("nombre: " + this._nombre);
            sb.AppendLine("apellido: " + this._apellido);
            sb.AppendLine("Dni: " + this._dni);

            return sb.ToString();
        }


    }
}
