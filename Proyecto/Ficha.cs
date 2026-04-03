using System;

namespace fichaParchis
{
    public class Ficha
    {
        private const int PosicionMeta = 71; // Posición de la meta en el tablero
        public string Color{get; set;}
        public int Posicion{get; set;}
        public bool EnCasa{get; set;}
        public bool EnMeta{get; set;}

        public Ficha(string color)
        {
            Color = color;
            Posicion = 0;
            EnCasa = true;
            EnMeta = false;
        }

        public bool SalirDeCasa(int valor)
        {
            if (EnCasa && valor == 6)
            {
                EnCasa = false;
                Posicion = 1; // La ficha sale de casa y se coloca en la posición inicial del tablero
                return true;
            }

            return false;
        }

        public bool Mover(int pasos)
        {
            if (EnCasa || EnMeta) return false;

            Posicion += pasos;
            if (Posicion >= PosicionMeta) // Suponiendo que la posición 71 es la meta
            {
                Posicion = PosicionMeta; // La ficha no puede avanzar más allá de la meta
                EnMeta = true; // La ficha ha llegado a la meta
            }

            return true;
        }

        // Método para regresar la ficha a casa
        public void RegresarACasa()
        {
            Posicion = 0; // La ficha regresa a la casa
            EnCasa = true;
            EnMeta = false;
        }

        // Método para mostrar el estado de la ficha
        public void MostrarEstado()
        {
            if (EnCasa)
            {
                Console.WriteLine($"La ficha de color {Color} está en casa.");
            }
            else if (EnMeta)
            {
                Console.WriteLine($"La ficha de color {Color} ha llegado a la meta.");
            }
            else
            {
                Console.WriteLine($"La ficha de color {Color} está en la posición {Posicion}.");
            }
        }
    }
}