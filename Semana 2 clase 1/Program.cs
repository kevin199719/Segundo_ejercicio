using System;

namespace Semana_2_clase_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Humano humano1 = new Humano();
            humano1.Nombre = "Kevin";
            humano1.Darnombre();
            humano1.Hablar();
            humano1.Reproducirse();

            Caballo caballo1 = new Caballo();
            caballo1.Nombre = "Silver";
            caballo1.Galopar();

            Delfin delfin1 = new Delfin();
            delfin1.Nombre = "winter";
            delfin1.Nadar();

            Gorila gorila1 = new Gorila();
            gorila1.Nombre = "King";
            gorila1.Trepar();

            Reptil iguana = new Reptil();

            iguana.Reproducirse();

        }
    }
}
