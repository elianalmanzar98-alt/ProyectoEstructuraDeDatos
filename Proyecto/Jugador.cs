using System;

namespace fichaParchis
{
    public class Jugador
    {
        public string Nombre { get; set; }
        public Ficha[] Fichas { get; set; }

        public Jugador(string nombre, string color)
        {
            Nombre = nombre;
            Fichas = new Ficha[4];

            for (int i = 0; i < 4; i++)
            {
                Fichas[i] = new Ficha(color);
            }
        }

        public bool HaGanado()
        {
            foreach (var f in Fichas)
            {
                if (!f.EnMeta) return false;
            }
            return true;
        }

        public void MostrarFichas()
        {
            Console.WriteLine($"\nFichas de {Nombre}:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write($"[{i}] ");
                Fichas[i].MostrarEstado();
            }
        }
    }
}