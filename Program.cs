using System;

namespace ProgramaBasico
{
    class Program
    {
        static void Main(string[] args)
        {
            // Salida de texto en consola
            Console.WriteLine("--- Bienvenido a la Calculadora de Edad ---");

            // Solicitar datos
            Console.Write("Por favor, ingresa tu año de nacimiento: ");
            string entrada = Console.ReadLine();

            // Convertir texto a número y calcular
            int anioNacimiento;
            if (int.TryParse(entrada, out anioNacimiento))
            {
                int anioActual = DateTime.Now.Year;
                int edad = anioActual - anioNacimiento;

                // Mostrar resultado
                Console.WriteLine($"\nHola! Tienes o cumplirás {edad} años en {anioActual}.");
            }
            else
            {
                Console.WriteLine("\nError: Por favor ingresa un año válido.");
            }

            Console.WriteLine("\nPresiona cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}