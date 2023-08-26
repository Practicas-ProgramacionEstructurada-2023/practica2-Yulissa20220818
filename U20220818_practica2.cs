using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //DECLARACION DE VARIABLES DE TEXTO CAPTURANDO DESDE LA TERMINAL
            string? nombre;
            string? apellido;

            //DECLARACION DE VARIABLES DE TEXTO DESDE CODIGO 
            string? codigo_estudiantil = "u20220818";
            string? becado = "No";

            //DECLARACION DE VARIABLES DE TIPO ENTERAS CAPTURANDO DESDE LA TERMINAL 
            int edad;

            //DECLARACION DE VARIABLES DE TIPO ENTERAS DESDE CODIGO
            int AñoIngreso = 2023;
            int AñoEgreso = 2025;

            //DECLARACION DE VARIABLES DECIMALES CAPTURANDO DESDE LA TERMINAL 
            double mensualidad;

            //DECLARACION DE VARIABLES DECIMALES DESDE CODIGO
            double transporte = 3.50;
            double alimentacion = 4;

            //DECLARACION DE VARIABLES DE TIEMPO O TIME
            DateTime FechaActual = DateTime.Now;
            DateTime FechaEspecifica = new DateTime (23, 8, 19, 16, 20, 00);

            //OBTENCION DE DATOS DESDE LA TERMINAL 
            Console.WriteLine("Ingrese su nombre: ");
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su apellido: ");
            apellido = Convert.ToString(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su edad: ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine("Ingrese su mensualidad universitaria: ");
            mensualidad = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            //IMPRESION DE DATOS 
            Console.WriteLine("*********************Inicio de impresion********************");
            Console.WriteLine("Su nombre: "+ nombre);
            Console.WriteLine("Su apellido es: "+ apellido);
            Console.WriteLine("Su codigo estudiantil es: "+ codigo_estudiantil);
            Console.WriteLine("Es becado? "+ becado);
            Console.WriteLine("Su edad es: "+ edad);
            Console.WriteLine("Su año de ingreso fue: "+ AñoIngreso);
            Console.WriteLine("Su año de egreso sera: "+ AñoEgreso);
            Console.WriteLine("Su mensualidad universitaria es: "+ "$"+ mensualidad);
            Console.WriteLine("Su gasto diario de transporte es: "+ "$"+ transporte);
            Console.WriteLine("Su gasto diario de alimentacion es: "+ "$"+ alimentacion);
            Console.WriteLine("La fecha y tiempo de impresion de datos es: "+FechaActual);
            Console.WriteLine("La fecha que termina la practica es: "+ FechaEspecifica);
            Console.WriteLine("*********************Fin de impresion********************");

            //APLICACION DE FUNCIONES DE CADENA 

            //FUNCION DE COMPARACION CADENAS DE TEXTO
            bool cadenaComparativa= nombre == apellido;

            //FUNCION DE MINUSCULA 
            string? funcionMinuscula1 = nombre.ToLower();
            string? funcionMinuscula2 = apellido.ToLower();

            //FUNCION DE MAYUSCULA 
            string? funcionMayuscula1 = nombre.ToUpper();
            string? funcionMayuscula2 = apellido.ToUpper();

            //FUNCION DE CONCATENADO
            int llogitudCadena1 = nombre.Length;
            int llogitudCadena2 = nombre.Length;

            //IMPRESION DE DATOS 
            Console.WriteLine("*********************Inicio de impresion********************");
            Console.WriteLine("Comparacion: "+ cadenaComparativa);
            Console.WriteLine("Mayuscula Nombre y Apellido: "+ funcionMayuscula1 + " " + funcionMayuscula2);
            Console.WriteLine("Minuscula Nombre y Apellido: "+ funcionMinuscula1 + " " + funcionMinuscula2);
            Console.WriteLine("Concatenacion: "+ cadenaComparativa);
            Console.WriteLine("La longitud de datos de nombre es: "+ llogitudCadena1);
            Console.WriteLine("La longitud de datos de apellido es: "+ llogitudCadena2);
            Console.WriteLine("*********************Fin de impresion********************");
        }
    }
}
