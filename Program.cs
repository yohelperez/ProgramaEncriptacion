using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CifradoCesar
{
    class Encriptador
    {
        /*El metodo encriptarMensaje recibe el mensaje y una variable por referencia de tipo entero. 
             * Para esta variable se generará un valor aleatorio y es la clave que se usara
             * para desencriptar el mensaje en el metodo desencriptarMensaje*/

        public static string encriptarMensaje(string mensaje, int clave)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz ";
            string nuevoMensaje = "";
            int letra;

            foreach (char caracter in mensaje)
            {

                for (int i = 0; i < alfabeto.Length; i++)
                {
                    if (caracter == alfabeto[i])
                    {
                        letra = i + clave;
                        if (letra >= 27)
                        {
                            letra = letra - 27;
                        }

                        nuevoMensaje += alfabeto[letra];
                    }
                }
            }

            //Console.WriteLine("clave: " + clave);
            return nuevoMensaje;
        }


        public static string desencriptarMensaje(string mensaje, int clave)
        {
            string alfabeto = "abcdefghijklmnopqrstuvwxyz ";
            string nuevoMensaje = "";
            int letra;

            foreach (char caracter in mensaje)
            {
                for (int i = 0; i < alfabeto.Length; i++)
                {
                    if (caracter == alfabeto[i])
                    {
                        letra = i - clave;
                        if (letra < 0)
                        {
                            letra = 27 + letra;
                        }

                        nuevoMensaje += alfabeto[letra];
                    }
                }
            }
            return nuevoMensaje;
        }
    }
}
