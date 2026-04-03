using System;

namespace fichaParchis
{
    public class Dado
    {
        private Random random;

        public Dado()
        {
            random = new Random();
        }

        public int Lanzar()
        {
            return random.Next(1, 7); // Genera un número aleatorio entre 1 y 6
        }
    }
}