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

        /// <summary>
        /// Metodo que separa el nombre de los apellidos y guarda los apellidos unidos en una sola variable
        /// </summary>
        /// <param name="concatenacion"></param>
        public string separarConcatenacion(string concatenacion, string apellidos);
        
        /// <summary>
        ///Metodo que calcula el tamaño de la variable nombreCompleto 
        /// </summary>
        /// <param name="nombreCompleto">nombreCompleto</param>
        public void calcularTamañoVariable(string nombreCompleto);

        /// <summary>
        /// Metodo que identifica la decima posicion de los apellidos
        /// </summary>
        /// <param name="apellidos"></param>
        public void decimoCaracterApellidos(string apellidos);

        /// <summary>
        /// Metodo que busca la primera vez que aparece "a" en el nombre
        /// </summary>
        /// <param name="nombre"></param>
        public void primeraANombre(string nombre);

        /// <summary>
        /// Metodo que busca la primera r de nombreCompleto a partir de la posición 3 y hasta la posición 10
        /// </summary>
        public void primeraRNombre(string nombreCompleto);

        /// <summary>
        /// Metodo que deletrea un nombre
        /// </summary>
        /// <param name="nombre"></param>
        public void deletrear(string nombre);

        /// <summary>
        /// Metodo que muestra la posicion del valor "arc"
        /// </summary>
        /// <param name="nombre"></param>
        public void nombreArcPosicion(string nombreCompleto);

            
    }
}
