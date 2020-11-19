using System;
using System.Collections.Generic;
using System.Text;

namespace NETCOREM1_Consola
{
    public class Principal
    {
        static void Main(string[] arg)
        {
            string nombreCurso = "Aplicaciones Web";
            string nombreParticipante = "Luis Chang";
            int edad = 25;
            string detalleEdad = String.Empty;
            double num1 = 10, num2 = 20;

            List<Persona> personas = new List<Persona>();

            Persona persona1 = new Persona();
            persona1.DNI = "99228822";
            persona1.Nombre = "Jose Ramos";
            persona1.Telefono = 9988772;

            Persona persona2 = new Persona("99110022", "Carlos Rojas", 998827);

            personas.Add(persona1);
            personas.Add(persona2);
            personas.Add(new Persona("66775522", "Juan Rosales", 77665522));

            if (edad > 17)
                detalleEdad = "Mayor de edad";
            else
                detalleEdad = "Menor de edad;";

            detalleEdad = (edad > 17) ? "Mayor de edad" : "Menor de edad";

            Console.WriteLine("Hola Mundo");
            Console.WriteLine("Bienvenido al curso: " + nombreParticipante);
            Console.WriteLine("Numéro: " + num1.ToString() + " Num2: " + num2.ToString());

            Console.WriteLine("Reporte de Personas");
            Console.WriteLine("************************");
            foreach (Persona persona in personas)
            {
                Console.WriteLine(persona.DNI + " - " + 
                                  persona.Nombre + " - " + 
                                  persona.Telefono);

            }


            Console.ReadKey();



        }



    }
}
