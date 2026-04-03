using System;

namespace fichaParchis
{
    class Program
    {
        static void Main(string[] args)
        {
            Jugador j1 = new Jugador("Juan", "Rojo");
            Jugador j2 = new Jugador("Ana", "Azul");

            Juego juego = new Juego(new Jugador[] { j1, j2 });
            juego.Iniciar();
        }
    }
}