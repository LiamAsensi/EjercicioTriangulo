/* Liam Alejo Asensi, 29/07/2022
 * Ejemplo de Programa en C# que dibuja un triángulo de asteriscos del
 * tamaño que indique el/la usuario/a*/

using System;

class EjercicioTriangulo
{
	public static void Main()
	{	
        try
        {
            Console.Write("Introduce la altura del triángulo: ");
            int altura = Convert.ToInt32(Console.ReadLine());
            
            if (altura <= 0) throw new Exception("Se ha introducido un número menor o igual que 0.");
            
            Console.WriteLine();
        
            for (int i = 1, ast = 1; i <= altura; i++, ast += 2)
            {
                for (int sp = 1; sp <= altura - i ; sp++)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= ast; j++)
                {
                    Console.Write("*");
                }
                for (int sp = 1; sp <= altura - i ; sp++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
        catch (Exception e)
        {
            Console.WriteLine("Error: {0}", e.Message);
        }
        
        
	}
}
