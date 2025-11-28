using System;

class Program
{
    static void Main(string[] args)
    {
        // 1. Crear un objeto Scripture con referencia y versículo
        Scripture s = new Scripture(
            "Juan 3:16",
            "Porque de tal manera amó Dios al mundo que ha dado a su Hijo unigénito"
        );

        // 2. Bucle interactivo para mostrar y ocultar palabras
        while (true)
        {
            Console.Clear(); // limpia la pantalla en cada iteración
            Console.WriteLine(s.GetRenderedText()); // muestra el versículo actual
            Console.WriteLine();
            Console.WriteLine("Presiona Enter para ocultar más palabras o escribe 'salir' para terminar.");

            string input = Console.ReadLine();
            if (input.ToLower() == "salir")
            {
                break; // salir del bucle
            }

            s.HideRandomWords(); // oculta 2 palabras aleatorias
        }
    }
}
