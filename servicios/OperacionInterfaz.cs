using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1String1.servicios
{
    internal interface OperacionInterfaz
    {
        /// <summary>
        /// Metodo que pide nombre y los dos apellidos, y verifica que nose repite el nombre
        /// </summary>
        public void VerificarNombre(string nombre, string apellido1, string apellido2);

        public void pedirDNI();

        public void pedirCodigPostal();

        public string concatenar(string nombre, string apellido1, string apellido2);

    }
}
