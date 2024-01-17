﻿using ejercicio1String1.servicios;
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
            bool cerrarBucle = false;
            while (!cerrarBucle)
            {
                Console.WriteLine("Inserte numero del DNI");
                int DNINumero = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Inserte letra del DNI");
                string DNILetra = Console.ReadLine();

                int DNINumeroResto = DNINumero % 23;

                if (DNINumeroResto == 0)
                {
                    if (DNILetra.Equals("T"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 1)
                {
                    if (DNILetra.Equals("R"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumero == 2)
                {
                    if (DNILetra.Equals("W"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 3)
                {
                    if (DNILetra.Equals("A"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 4)
                {
                    if (DNILetra.Equals("G"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 5)
                {
                    if (DNILetra.Equals("M"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 6)
                {
                    if (DNILetra.Equals("Y"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 7)
                {
                    if (DNILetra.Equals("F"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 8)
                {
                    if (DNILetra.Equals("P"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 9)
                {
                    if (DNILetra.Equals("D"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 10)
                {
                    if (DNILetra.Equals("X"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 11)
                {
                    if (DNILetra.Equals("B"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 12)
                {
                    if (DNILetra.Equals("N"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 13)
                {
                    if (DNILetra.Equals("J"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 14)
                {
                    if (DNILetra.Equals("Z"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 15)
                {
                    if (DNILetra.Equals("S"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 16)
                {
                    if (DNILetra.Equals("Q"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 17)
                {
                    if (DNILetra.Equals("V"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 18)
                {
                    if (DNILetra.Equals("H"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 19)
                {
                    if (DNILetra.Equals("L"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 20)
                {
                    if (DNILetra.Equals("C"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 21)
                {
                    if (DNILetra.Equals("K"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
                }
                if (DNINumeroResto == 22)
                {
                    if (DNILetra.Equals("E"))
                    {
                        cerrarBucle = true;
                    }
                    else
                    {
                        Console.WriteLine("El DNI es erroneo, vuelva a insertarlo");
                        Console.WriteLine(" ");
                    }
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
