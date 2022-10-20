using System;
using System.IO; //Importamos para poder usar el File.

namespace Full_GRASP_And_SOLID.Library
{
    public class FilePrinter: IPrinter   // Heredamos de la interfaz
    {
        public void Printer(Recipe recipe)
        {
            File.WriteAllText("Recipe.txt", recipe.GetTextToPrint());
        }
    }
}

/*Creamos esta clase para no tener que andar especificando el destino cada vez que queremos imprimir.
También podríamos crearla de una vez en el Program*/