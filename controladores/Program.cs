using ejercicio1String.Servicios;
using ejercicio1String1.servicios;

namespace ejercicio1String1.controladores
{

    class Program
    {

        public static void Main(string[] args)
        {
            //Pide un nombre, primer y segundo apellidos, por consola y valida que el nombre no coincide con ninguno de los apellidos. 
            OperacionInterfaz op = new OperacionImplementacion();
            op.PedirNombreYApellido();

            //Pide el dni por consola y valida que tiene un formato correcto: en el enlace se explica como se calcula la letra de un dni para poder validarlo. 
            op.pedirDNI();

            //Pide el código postal por consola y valida que es de la ciudad de Sevilla: en el enlace tienes los códigos postales de Sevilla
            op.pedirCodigPostal();
        }
    }
}