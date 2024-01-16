using ejercicio1String.Servicios;
using ejercicio1String1.servicios;

namespace ejercicio1String1.controladores
{

    class Program
    {

        public static void Main(string[] args)
        {
            string nombre ="";
            string apellido1 = "";
            string apellido2 = "";

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
            Console.WriteLine(" ");
            string Concatenar = op.concatenar(nombre, apellido1, apellido2);   
            Console.WriteLine(Concatenar);


            //Separa la concatenación y guarda los apellidos unidos en una sola variable.
            Console.WriteLine(" ");
            Console.WriteLine("Separacion de apellidos y nombre");
            string[] textoSeparado = Concatenar.Split(",");
            foreach (string s in textoSeparado)
            {
                Console.WriteLine(s);
            }
            string apellidos = textoSeparado[0];


            //Calcula el tamaño de la variable con el nombre completo.
            Console.WriteLine(" ");
            Console.WriteLine("Calcular tamaño de la variable con el nombre completo");
            Console.WriteLine(apellidos.Length + Concatenar.Length);


            //Recupera y muestra por consola el décimo carácter de la variable con los apellidos.
            Console.WriteLine(" ");
            Console.WriteLine("El decimo caracter de la variable apellido");
            Console.WriteLine(apellidos.Substring(9, 1));

            //Busca la primera vez que aparece la letra a en el nombre completo.

        }
    }
}