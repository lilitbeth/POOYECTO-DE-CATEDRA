using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace POOYECTO_DE_CATEDRA
{
    internal class Persona
    {
        public string nombre;
        public string apellido;
        public string correo;
        public string telefono;
        public string Nombre 
        { 
            get { return nombre; }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("El nombre no debe quedar vacío");

                }
                nombre = value;
            }
        }

        public string Apellido 
        {
            get { return apellido; }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("El apellido no debe quedar vacío");
                }
                apellido = value;
            }
        }
        public string Correo { get; set; }
        public string Telefono { get; set; }

        public static bool ValidarCorreo(string correo)
        {
            string expresion = "^[_a-z0-9-]+(.[_a-z0-9-]+)*@[a-z0-9-]+(.[a-z0-9-]+)*(.[a - z]{ 2,4})$";
            if (Regex.IsMatch(correo, expresion))
            {
                if (Regex.Replace(correo, expresion,string.Empty).Length == 0)
                {
                    return true;
                }
                else
                {
                    return false;

                }
            }
            else
            {
                return false;
            }
        }

        public static bool ValidarTelefono(string telefono)
        {
            string expresion = "^[0-9]{4}-[0-9]{4}$";
            if (Regex.IsMatch(telefono, expresion))
            {
                if (Regex.Replace(telefono, expresion, string.Empty).Length == 0)
                {  
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }

    }
}
