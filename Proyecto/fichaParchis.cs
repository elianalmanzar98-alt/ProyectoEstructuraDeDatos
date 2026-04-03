using System;

namespace fichaParchis
{
    public class Juego
    {
        private Jugador[] jugadores;
        private int turnoActual;
        private Dado dado;
        private Tablero tablero;

        public Juego(Jugador[] jugadores)
        {
            this.jugadores = jugadores;
            dado = new Dado();
            tablero = new Tablero();
            turnoActual = 0;
        }

        public void Iniciar()
        {
            Console.WriteLine("=== PARCHÍS CON GRAFOS ===");

            while (true)
            {
                Jugador jugador = jugadores[turnoActual];

                Console.WriteLine($"\nTurno de {jugador.Nombre}");
                Console.ReadKey();

                int valor = dado.Lanzar();
                Console.WriteLine($"Dado: {valor}");

                jugador.MostrarFichas();

                Console.Write("Elige ficha (0-3): ");
                if (!int.TryParse(Console.ReadLine(), out int opcion) || opcion < 0 || opcion >= jugador.Fichas.Length)
                {
                    Console.WriteLine("Opción inválida. Se salta el turno.");
                    if (valor != 6)
                    {
                        turnoActual = (turnoActual + 1) % jugadores.Length;
                    }
                    continue;
                }

                Ficha ficha = jugador.Fichas[opcion];

                if (ficha.EnCasa)
                {
                    if (!ficha.SalirDeCasa(valor))
                    {
                        Console.WriteLine("No puedes salir sin un 6.");
                    }
                }
                else
                {
                    ficha.Mover(valor);
                }

                // Verificar meta
                if (ficha.EnMeta)
                {
                    Console.WriteLine("¡Ficha llegó a la meta!");
                }

                // Verificar ganador
                if (jugador.HaGanado())
                {
                    Console.WriteLine($"\n🏆 Ganador: {jugador.Nombre}");
                    break;
                }

                // Turno extra si saca 6
                if (valor != 6)
                {
                    turnoActual = (turnoActual + 1) % jugadores.Length;
                }
            }
        }
    }
}