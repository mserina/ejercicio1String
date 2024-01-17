using ejercicio1String.Servicios;
using ejercicio1String1.servicios;
using System.Reflection;

namespace ejercicio1String1.controladores
{
    /// <summary>
    /// Clase principal del programa 
    /// </summary>
    class Program
    {

        public static void Main(string[] args)
        {
            string nombre ="";
            string apellido1 = "";
            string apellido2 = "";
            string nombreCompleto = "";
            string apellidos = "";

            Console.WriteLine("Insertar nombre, la primera letra Mayuscula");
             nombre = Console.ReadLine();
            Console.WriteLine("Inserte primer apellido, la primera letra Mayuscula");
             apellido1 = Console.ReadLine();
            Console.WriteLine("Inserte segundo apellido, la primera letra Mayuscula");
             apellido2 = Console.ReadLine(); if (!nombre.Equals(apellido1));

            OperacionInterfaz op = new OperacionImplementacion();


            //Pide un nombre, primer y segundo apellidos, por consola y valida que el nombre no coincide con ninguno de los apellidos. 

            op.VerificarNombre(nombre, apellido1, apellido2);


            //Pide el dni por consola y valida que tiene un formato correcto: en el enlace se explica como se calcula la letra de un dni para poder validarlo. 
            op.pedirDNI();


            //Pide el código postal por consola y valida que es de la ciudad de Sevilla: en el enlace tienes los códigos postales de Sevilla
            op.pedirCodigPostal();


            //Concatena el nombre y los apellidos en una sola variable de tipo string con el siguiente formato: "apellido1 apellido2, nombre."
            nombreCompleto = op.concatenar(nombre, apellido1, apellido2);


            //Separa la concatenación y guarda los apellidos unidos en una sola variable.
            apellidos = op.separarConcatenacion(nombreCompleto, apellidos);


            //Calcula el tamaño de la variable con el nombre completo.
            op.calcularTamañoVariable(nombreCompleto);


            //Recupera y muestra por consola el décimo carácter de la variable con los apellidos.
            op.decimoCaracterApellidos(apellidos);


            //Busca la primera vez que aparece la letra a en el nombre completo.
            op.primeraANombre(nombreCompleto);


            //Busca la primera vez que aparezca la letra r a partir de la posición 3 y hasta la posición 10 en el nombre completo.
            op.primeraRNombre(nombreCompleto);


            //Toma la variable nombre y guárdala en una nueva variable separando cada letra: Marcos -> M a r c o s
            op.deletrear(nombre);


            //Indica la posición del valor "arc" dentro del nombre completo.
            //!!!Preguntar como se hace
            op.nombreArcPosicion(nombreCompleto);



        }
    }
}