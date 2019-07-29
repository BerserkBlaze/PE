using System;


namespace Sucesion_Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine(SerieFibonacci(12));
        }

        static int SerieFibonacci(int limite)
        {
            int FiBo0 = 0, FiBo1 = 1, Aux = 0;
            if (limite==2)
            {
                Aux = 1;
            }
           
            for (int i = 3; i <= limite; i++)
            {
                Aux = FiBo0 + FiBo1;
                FiBo0 = FiBo1;
                FiBo1 = Aux;
            }
            return Aux;
        }
    }
}
