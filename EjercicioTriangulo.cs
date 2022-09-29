/* Liam Alejo Asensi, 29/07/2022
 * Ejemplo de Programa en C# que dibuja un triángulo de asteriscos del
 * tamaño que indique el/la usuario/a*/

using System;

class EjercicioTriangulo
{
	public static void Main()
	{
        bool flag = false;
        int altura = 0;
        
        /* Código para pedir los datos del programa y asegurarse de que introduce una cantidad correcta del tamaño
         * para el triángulo, y que también sea un número y no un string*/
        do
        {
            try
            {
                Console.Write("Introduce la altura del triángulo: ");
                altura = Convert.ToInt32(Console.ReadLine());
                
                if (altura <= 0) throw new Exception("Se ha introducido un número menor o igual que 0.\n");
                else if (altura > 50) throw new Exception("Se ha introducido un número demasiado grande.\n");
                
                flag = true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: {0}\n", e.Message);
            }
        } while (!flag);
        
        Console.WriteLine();
        
        /* Código para crear el triángulo. Se trata de un bucle principal que va recorriendo las filas del triángulo
         * mientras también aumenta el número de asteriscos que se dibujan de dos en dos. Dentro hay dos bucles, uno
         * para dibujar los espacios y otro para los asteriscos*/
        for (int filaActual = 1, cantAsterisco = 1; filaActual <= altura; filaActual++, cantAsterisco += 2)
        {
            for (int colEspacio = 1; colEspacio <= altura - filaActual ; colEspacio++) Console.Write(" ");
            for (int colAsterisco = 1; colAsterisco <= cantAsterisco; colAsterisco++) Console.Write("*");
            
            Console.WriteLine();
        }
	}
}
