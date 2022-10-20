
using System;
using System.IO; //Importamos para poder usar el File.

namespace Full_GRASP_And_SOLID.Library
{
    public class ConsolePrinter: IPrinter
    {
        public void Printer(Recipe recipe)
        {
            Console.WriteLine(recipe.GetTextToPrint());
        }
    }
}

/*Creamos esta clase para no tener que andar especificando el destino cada vez que queremos imprimir.
También podríamos crearla de una vez en el Program*/