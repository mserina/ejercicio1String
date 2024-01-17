using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1String1.servicios
{
    /// <summary>
    /// Interfaz, que contiene la cabezera de los metodos
    /// msm - 170124
    /// </summary>
    internal interface OperacionInterfaz
    {
        /// <summary>
        /// Metodo que pide nombre y los dos apellidos, y verifica que nose repite el nombre
        /// msm-170124
        /// </summary>
        public void VerificarNombre(string nombre, string apellido1, string apellido2);

        /// <summary>
        /// Metodo que pide el DNI y verifica si es correcto
        /// msm-170124
        /// </summary>
        public void pedirDNI();

        /// <summary>
        /// Metodo que pide el codigo Postal y verifica si es de Sevilla
        /// msm-170124
        /// </summary>
        public void pedirCodigPostal();

        /// <summary>
        /// Metodo que concatena los apellidos con el nombre
        /// msm-170124
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido1"></param>
        /// <param name="apellido2"></param>
        /// <returns>Devuelve el nombre completo</returns>
        public string concatenar(string nombre, string apellido1, string apellido2);

        /// <summary>
        /// Metodo que separa el nombre de los apellidos y guarda los apellidos unidos en una sola variable
        /// msm-170124
        /// </summary>
        /// <param name="concatenacion"></param>
        public string separarConcatenacion(string concatenacion, string apellidos);

        /// <summary>
        ///Metodo que calcula el tamaño de la variable nombreCompleto 
        ///msm-170124
        /// </summary>
        /// <param name="nombreCompleto">nombreCompleto</param>
        public void calcularTamañoVariable(string nombreCompleto);

        /// <summary>
        /// Metodo que identifica la decima posicion de los apellidos
        /// msm-170124
        /// </summary>
        /// <param name="apellidos"></param>
        public void decimoCaracterApellidos(string apellidos);

        /// <summary>
        /// Metodo que busca la primera vez que aparece "a" en el nombre
        /// msm-170124
        /// </summary>
        /// <param name="nombre"></param>
        public void primeraANombre(string nombre);

        /// <summary>
        /// Metodo que busca la primera r de nombreCompleto a partir de la posición 3 y hasta la posición 10
        /// msm-170124
        /// </summary>
        public void primeraRNombre(string nombreCompleto);

        /// <summary>
        /// Metodo que deletrea un nombre
        /// msm-170124
        /// </summary>
        /// <param name="nombre"></param>
        public void deletrear(string nombre);

        /// <summary>
        /// Metodo que muestra la posicion del valor "arc"
        /// msm-170124
        /// </summary>
        /// <param name="nombre"></param>
        public void nombreArcPosicion(string nombreCompleto);

            
    }
}
