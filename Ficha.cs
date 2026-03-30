using System;

namespace fichaParchis
{
    public class Ficha
    {
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

        public void salirCasa()
        {
            if (EnCasa)
            {
                EnCasa = false;
                Posicion = 1; // La ficha sale de casa y se coloca en la posición inicial del tablero
            }
        }

        public void mover(int pasos)
        {
            if (!EnCasa && !EnMeta)
            {
                Posicion += pasos;
                if (Posicion >= 71) // Suponiendo que la posición 71 es la meta
                {
                    Posicion = 71; // La ficha no puede avanzar más allá de la meta
                    EnMeta = true; // La ficha ha llegado a la meta
                }
            }
        }
        // Método para regresar la ficha a casa
        public void regresarCasa()
        {
            Posicion = 0;
            EnCasa = true;
            EnMeta = false;
        }

        // Método para mostrar el estado de la ficha
        public void mostrarEstado()
        {
            if(EnCasa)
            {
                Console.WriteLine($"La ficha de color {Color} está en casa.");
            }
            else if(EnMeta)
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