using ejercicio1String1.servicios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1String.Servicios
{
    /// <summary>
    /// Metodo que contiene la logica de los metodos 
    /// msm-170124
    /// </summary>
    internal class OperacionImplementacion : OperacionInterfaz
    {
        public void VerificarNombre(string nombre, string apellido1, string apellido2)
        {
            bool cerrarBucle = false;
            while (!cerrarBucle)
            {               
                if (!nombre.Equals(apellido1))
                {

                    if (!nombre.Equals(apellido2))
                    {
                        cerrarBucle=true;
                    }
                    else
                    {
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.WriteLine("El segundo apellido es igual que el nombre, inserte correctamente");
                        Console.WriteLine("------------------------------------------------------------------");
                        Console.WriteLine(" ");
                    }
                }
                else
                {
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine("El primer apellido es igual que el nombre, inserte correctamente");
                    Console.WriteLine("------------------------------------------------------------------");
                    Console.WriteLine(" ");
                }
            }
        }

        public void pedirDNI()
        {
            string[] letrasDNI = new string[23];
            letrasDNI[0] = "T";
            letrasDNI[1] = "R";
            letrasDNI[2] = "W";
            letrasDNI[3] = "A";
            letrasDNI[4] = "G";
            letrasDNI[5] = "M";
            letrasDNI[6] = "Y";
            letrasDNI[7] = "F";
            letrasDNI[8] = "P";
            letrasDNI[9] = "D";
            letrasDNI[10] = "X";
            letrasDNI[11] = "B";
            letrasDNI[12] = "N";
            letrasDNI[13] = "J";
            letrasDNI[14] = "Z";
            letrasDNI[15] = "S";
            letrasDNI[16] = "Q";
            letrasDNI[17] = "V";
            letrasDNI[18] = "H";
            letrasDNI[19] = "L";
            letrasDNI[20] = "C";
            letrasDNI[21] = "K";
            letrasDNI[22] = "E";

            int[] numeroDni = new int[23];
            numeroDni[0] = 0;
            numeroDni[1] = 1;
            numeroDni[2] = 2;
            numeroDni[3] = 3;
            numeroDni[4] = 4;
            numeroDni[5] = 5;
            numeroDni[6] = 6;
            numeroDni[7] = 7;
            numeroDni[8] = 8;
            numeroDni[9] = 9;
            numeroDni[10] = 10;
            numeroDni[11] = 11;
            numeroDni[12] = 12;
            numeroDni[13] = 13;
            numeroDni[14] = 14;
            numeroDni[15] = 15;
            numeroDni[16] = 16;
            numeroDni[17] = 17;
            numeroDni[18] = 18;
            numeroDni[19] = 19;
            numeroDni[20] = 20;
            numeroDni[21] = 21;
            numeroDni[22] = 22;

            bool cerrarBucle = false;
            while (!cerrarBucle)
            {
                Console.WriteLine("Inserte numero del DNI");
                int DNINumero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte letra del DNI");
                string DNILetra = Console.ReadLine();

                int DNINumeroResto = DNINumero % 23;

               
                 if (numeroDni[DNINumeroResto] == DNINumeroResto)
                    {
                      if(DNILetra == letrasDNI[DNINumeroResto])
                      {
                        cerrarBucle = true;
                      }
                      else
                      {
                        Console.WriteLine("Ese dni no existe");
                      }
                 }
                 else
                 {
                   Console.WriteLine("Ese dni no existe");
                 }         
            }
        }

        public void pedirCodigPostal()
        {
            Console.WriteLine("Codigo postal: ");
            string codigoPostal = Console.ReadLine();
            string tresDigitos = codigoPostal.Substring(0, 3);

            if (tresDigitos == "410")
            {
                Console.WriteLine("Es de sevilla");
            }
            else
            {
                Console.WriteLine("No es de sevilla");
            }
        }

        public string concatenar(string nombre, string apellido1, string apellido2)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Concatenacion: ");
            string concatenacion = apellido1 + " " + apellido2 +","+ nombre + ".";
            Console.WriteLine(concatenacion);
            return concatenacion;
        }

        public string separarConcatenacion(string concatenacion, string apellidos)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Separacion de apellidos y nombre");
            string[] textoSeparado = concatenacion.Split(",");                                                                                                                                                                                         
            foreach (string s in textoSeparado)
            {
                Console.WriteLine(s);
            }
            apellidos = textoSeparado[0];
            return apellidos;

        }

        public void calcularTamañoVariable(string nombreCompleto)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Calcular tamaño de la variable con el nombre completo");
            Console.WriteLine(nombreCompleto.Length);
        }

        public void decimoCaracterApellidos(string apellidos)
        {
            Console.WriteLine(" ");
            Console.WriteLine("El decimo caracter de la variable apellido");
            Console.WriteLine(apellidos.Substring(10, 1));
        }

        public void primeraANombre(string nombreCompleto)
        {
            Console.WriteLine(" ");
            Console.WriteLine("La primera vez que aparece la letra a en el nombre completo.");
            int indice = nombreCompleto.IndexOf("a");
            Console.WriteLine(indice);
        }

        public void primeraRNombre(string nombreCompleto)
        {
            Console.WriteLine(" ");
            Console.WriteLine("La primera vez que aparece la letra r a partir de la posicion 3");
            int indiceR = nombreCompleto.IndexOf("r", 3, 10);
            Console.WriteLine(indiceR);
        }

        public void deletrear(string nombre)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Deletrear Nombre");
            char[] nombreDeletreado = nombre.ToCharArray();
            foreach (char c in nombreDeletreado)
            {
                Console.WriteLine(c);
            }
        }

        public void nombreArcPosicion(string nombreCompleto)
        {
            Console.WriteLine(" ");
            Console.WriteLine("Posicion de arc");
            int arcPosicion = nombreCompleto.IndexOf("arc");
            Console.WriteLine(arcPosicion);
        }
    }
}
