using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clas10;


namespace clas10
{
    public class Alumno: Persona
    {
       // private string _nombre;
       // private string _apellido;
       // private int _dni;
        private List<float> _notas;
        private string _curso;


        public Alumno(string nombre, string apellido, int dni):base (nombre,apellido,dni)
        {

            //this._nombre = nombre;
            //this._apellido = apellido;
            //this._dni = dni; no va porque heredo los atributos de la clase padre 

            this._notas = new List<float>(); // instanciar una lista.

        }
        public Alumno(string nombre, string apellido, int dni, string curso)//:base (nombre,apellido,dni)
            : this(nombre, apellido, dni)
        { this._curso = curso; }


        public  string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar());
            sb.AppendLine("nombre: " + base._nombre);//sb.AppendLine("nombre: " + this._nombre);
            sb.AppendLine("apellido: " +base._apellido);
            sb.AppendLine("Dni: " + base._dni);

            return sb.ToString();
        }
    }
}
