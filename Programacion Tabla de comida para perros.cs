using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int raza, edad, peso, actividad;
            Console.Write("Indique la edad de su perro (meses): ");
            edad = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
            if (edad > 12)
            {
                Console.Write("Indique el peso de su perro (kg): ");
                peso = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                Console.WriteLine("Indique la actividad fisica de su perro: ");
                Console.WriteLine("1. Actividad Alta: ");
                Console.WriteLine("2. Actividad Media: ");
                Console.WriteLine("3. Actividad Baja: ");
                Console.Write("Elije una opción (número): ");
                actividad = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                if (peso >= 2 && peso < 5) {
                    switch(actividad){
                        case 1:
                            Console.WriteLine("Su cachorro debería consumir 60 a 115 gr de comida diaria para mantenerse saludable.");
                            break;
                        case 2:
                            Console.WriteLine("Su cachorro debería consumir 55 a 100 gr de comida diaria para mantenerse saludable.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debería consumir 45 a 85 gr de comida diaria para mantenerse saludable.");
                            break;
                        default:
                            Console.WriteLine("Nivel de Actividad no disponible.");
                            break;
                    }
                }
                else if (peso >= 5 && peso < 10)
                {
                    switch (actividad)
                    {
                        case 1:
                            Console.WriteLine("Su cachorro debería consumir 115 a 190 gr de comida diaria para mantenerse saludable.");
                            break;
                        case 2:
                            Console.WriteLine("Su cachorro debería consumir 100 a 170 gr de comida diaria para mantenerse saludable.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debería consumir 85 a 145 gr de comida diaria para mantenerse saludable.");
                            break;
                        default:
                            Console.WriteLine("Nivel de Actividad no disponible.");
                            break;
                    }
                }
                else if (peso >= 10 && peso < 15)
                {
                    switch (actividad)
                    {
                        case 1:
                            Console.WriteLine("Su cachorro debería consumir 190 a 255 gr de comida diaria para mantenerse saludable.");
                            break;
                        case 2:
                            Console.WriteLine("Su cachorro debería consumir 170 a 225 gr de comida diaria para mantenerse saludable.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debería consumir 145 a 195 gr de comida diaria para mantenerse saludable.");
                            break;
                        default:
                            Console.WriteLine("Nivel de Actividad no disponible.");
                            break;
                    }
                }
                else if (peso >= 15 && peso < 25)
                {
                    switch (actividad)
                    {
                        case 1:
                            Console.WriteLine("Su cachorro debería consumir 255 a 380 gr de comida diaria para mantenerse saludable.");
                            break;
                        case 2:
                            Console.WriteLine("Su cachorro debería consumir 225 a 330 gr de comida diaria para mantenerse saludable.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debería consumir 195 a 285 gr de comida diaria para mantenerse saludable.");
                            break;
                        default:
                            Console.WriteLine("Nivel de Actividad no disponible.");
                            break;
                    }
                }
                else if (peso >= 25 && peso < 40)
                {
                    switch (actividad)
                    {
                        case 1:
                            Console.WriteLine("Su cachorro debería consumir 380 a 535 gr de comida diaria para mantenerse saludable.");
                            break;
                        case 2:
                            Console.WriteLine("Su cachorro debería consumir 330 a 475 gr de comida diaria para mantenerse saludable.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debería consumir 285 a 410 gr de comida diaria para mantenerse saludable.");
                            break;
                        default:
                            Console.WriteLine("Nivel de Actividad no disponible.");
                            break;
                    }
                }
                else if (peso >= 40 && peso < 55)
                {
                    switch (actividad)
                    {
                        case 1:
                            Console.WriteLine("Su cachorro debería consumir 535 a 680 gr de comida diaria para mantenerse saludable.");
                            break;
                        case 2:
                            Console.WriteLine("Su cachorro debería consumir 475 a 600 gr de comida diaria para mantenerse saludable.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debería consumir 410 a 520 gr de comida diaria para mantenerse saludable.");
                            break;
                        default:
                            Console.WriteLine("Nivel de Actividad no disponible.");
                            break;
                    }
                }
                else if (peso >= 55 && peso < 70)
                {
                    switch (actividad)
                    {
                        case 1:
                            Console.WriteLine("Su cachorro debería consumir 680 a 820 gr de comida diaria para mantenerse saludable.");
                            break;
                        case 2:
                            Console.WriteLine("Su cachorro debería consumir 600 a 720 gr de comida diaria para mantenerse saludable.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debería consumir 520 a 620 gr de comida diaria para mantenerse saludable.");
                            break;
                        default:
                            Console.WriteLine("Nivel de Actividad no disponible.");
                            break;
                    }
                }
                else if (peso >= 70 && peso < 90)
                {
                    switch (actividad)
                    {
                        case 1:
                            Console.WriteLine("Su cachorro debería consumir 820 a 985 gr de comida diaria para mantenerse saludable.");
                            break;
                        case 2:
                            Console.WriteLine("Su cachorro debería consumir 720 a 870 gr de comida diaria para mantenerse saludable.");
                            break;
                        case 3:
                            Console.WriteLine("Su cachorro debería consumir 620 a 750 gr de comida diaria para mantenerse saludable.");
                            break;
                        default:
                            Console.WriteLine("Nivel de Actividad no disponible.");
                            break;
                    }
                }
                else {
                    Console.WriteLine("Su perro no esta dentro de los limites de peso establecidos.");
                }
            }
            else {
                Console.WriteLine("Su perro es de raza:");
                Console.WriteLine("Indique la edad de su perro: ");
                Console.WriteLine("1. Miniatura");
                Console.WriteLine("2. Pequeño");
                Console.WriteLine("3. Mediano");
                Console.WriteLine("4. Grande");
                Console.Write("Elije una opción (número): ");
                raza = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                

                switch(raza){
                    case 1:
                        if (edad == 2) { 
                            Console.WriteLine("Su cachorro debería consumir 50 gr de comida diaria para tener un peso ideal de 2kg cuando sea adulto.");
                        }
                        else if (edad == 3) {
                            Console.WriteLine("Su cachorro debería consumir 60 gr de comida diaria para tener un peso ideal de 2 kg cuando sea adulto.");
                        }
                        else if (edad == 4)
                        {
                            Console.WriteLine("Su cachorro debería consumir 60 gr de comida diaria para tener un peso ideal de 2 kg cuando sea adulto.");
                        }
                        else if (edad == 5)
                        {
                            Console.WriteLine("Su cachorro debería consumir 60 gr de comida diaria para tener un peso ideal de 2 kg cuando sea adulto.");
                        }
                        else if (edad >= 6 && edad <= 12)
                        {
                            Console.WriteLine("Su cachorro debería consumir 55 gr de comida diaria para tener un peso ideal de 2 kg cuando sea adulto.");
                        }
                        break;
                    case 2:
                        if (edad == 2)
                        {
                            Console.WriteLine("Su cachorro debería consumir de 95 a 155 gr de comida diaria para tener un peso ideal de 5 a 10 kg cuando sea adulto.");
                        }
                        else if (edad == 3)
                        {
                            Console.WriteLine("Su cachorro debería consumir de 110 a 185 gr de comida diaria para tener un peso ideal de 5 a 10 kg cuando sea adulto.");
                        }
                        else if (edad == 4)
                        {
                            Console.WriteLine("Su cachorro debería consumir de 115 a 195 gr de comida diaria para tener un peso ideal de 5 a 10 kg cuando sea adulto.");
                        }
                        else if (edad == 5)
                        {
                            Console.WriteLine("Su cachorro debería consumir de 115 a 190 gr de comida diaria para tener un peso ideal de 5 a 10 kg cuando sea adulto.");
                        }
                        else if (edad >= 6 && edad <= 12)
                        {
                            Console.WriteLine("Su cachorro debería consumir de 110 a 185 gr de comida diaria para tener un peso ideal de 5 a 10 kg cuando sea adulto.");
                        }
                        break;
                    case 3:
                        if (edad == 2)
                        {
                            Console.WriteLine("Su cachorro debería consumir 215 gr de comida diaria para tener un peso ideal de 17kg cuando sea adulto.");
                        }
                        else if (edad == 3)
                        {
                            Console.WriteLine("Su cachorro debería consumir 265 gr de comida diaria para tener un peso ideal de 17kg cuando sea adulto.");
                        }
                        else if (edad == 4)
                        {
                            Console.WriteLine("Su cachorro debería consumir 285 gr de comida diaria para tener un peso ideal de 17kg cuando sea adulto.");
                        }
                        else if (edad == 5)
                        {
                            Console.WriteLine("Su cachorro debería consumir 285 gr de comida diaria para tener un peso ideal de 17kg cuando sea adulto.");
                        }
                        else if (edad >= 6 && edad <= 12)
                        {
                            Console.WriteLine("Su cachorro debería consumir 280 gr de comida diaria para tener un peso ideal de 17kg cuando sea adulto.");
                        }
                        break;
                    case 4:
                        if (edad == 2)
                        {
                            Console.WriteLine("Su cachorro debería consumir de 270 a 580 gr de comida diaria para tener un peso ideal de 25 a 90 kg cuando sea adulto.");
                        }
                        else if (edad == 3)
                        {
                            Console.WriteLine("Su cachorro debería consumir de 350 a 670 gr de comida diaria para tener un peso ideal de 25 a 90 kg cuando sea adulto.");
                        }
                        else if (edad == 4)
                        {
                            Console.WriteLine("Su cachorro debería consumir de 375 a 685 gr de comida diaria para tener un peso ideal de 25 a 90 kg cuando sea adulto.");
                        }
                        else if (edad == 5)
                        {
                            Console.WriteLine("Su cachorro debería consumir de 375 a 625 gr de comida diaria para tener un peso ideal de 25 a 90 kg cuando sea adulto.");
                        }
                        else if (edad >= 6 && edad <= 12)
                        {
                            Console.WriteLine("Su cachorro debería consumir de 370 a 530 gr de comida diaria para tener un peso ideal de 25 a 90 kg cuando sea adulto.");
                        }
                        break;
                    default:
                        Console.WriteLine("Opción no disponible.");
                        break;
                }
                
            }
            Console.WriteLine("Presione enter para salir...");
            Console.ReadLine();
        }
    }
}