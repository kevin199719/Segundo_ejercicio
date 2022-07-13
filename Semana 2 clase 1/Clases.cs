using System;
using System.Collections.Generic;
using System.Text;

namespace Semana_2_clase_1
{
    //clase abstrapta
    abstract class Animal
    {
        public abstract void Reproducirse();

        public void moverser()
        {
            Console.WriteLine("El animal se esta moviendo. ");
        }
    }

    class Reptil : Animal 
    {
        // Metodo abstrapto 
        public override void Reproducirse()
        {
            Console.WriteLine("El reptil anida huevos.");
        }
    }








    // clase padre
    class Mamifero : Animal
       
    {
        //metodo abstrapto
        public override void Reproducirse()
        {
            Console.WriteLine("El Humano da a luz en un parto");
        }

        //Atributo
       public string Nombre { get; set; }

        //metodos
        public void Darnombre()
        {
            Console.WriteLine("Mi nombre es " + Nombre);
        }
    }

    //Clases hijas
    class Humano : Mamifero
    {
        public void Hablar()
            {
            Console.WriteLine("El humano esta hablando. ");
            }
    }

    class Caballo : Mamifero
    {
        public void Galopar()
        {
            Console.WriteLine("El caballo galopa. ");
        }
    }

    class Delfin : Mamifero
    {
        public void Nadar()
        {
            Console.WriteLine("El delfin nada. ");
        }
    }

    class Gorila : Mamifero
    {
        public void Trepar()
        {
            Console.WriteLine("El gorila sube el arbol. ");
        }
    }
}
