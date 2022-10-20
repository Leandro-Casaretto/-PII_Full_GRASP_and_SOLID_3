using System;

namespace Full_GRASP_And_SOLID.Library
{
    public interface IPrinter
    {
        public void Printer(Recipe recipe);
    }
}

/* Como borramos AllInOnePrinter, creamos esta interfaz basándonos en el patron de polimorfismo. Esta 
interfaz nos sirve para crear las clases PrintFile y PrintConsola.*/