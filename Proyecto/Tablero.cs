using System.Collections.Generic;

namespace fichaParchis
{
    public class Tablero
    {
        public Dictionary<int, Nodo> Nodos { get; set; }

        public Tablero()
        {
            Nodos = new Dictionary<int, Nodo>();
            CrearTablero();
        }

        private void CrearTablero()
        {
            // Crear nodos
            for (int i = 1; i <= 71; i++)
            {
                Nodos[i] = new Nodo(i);
            }

            // Conectar nodos (esto es un ejemplo, se pueden ajustar según las reglas del juego)
            for (int i = 1; i < 71; i++)
            {
                Nodos[i].Conectar(Nodos[i + 1]);
            }

            // Marcar meta
            Nodos[71].EsMeta = true;

            // Casillas seguras (esto es un ejemplo, se pueden ajustar según las reglas del juego)
            Nodos[1].EsSeguro = true;
            Nodos[8].EsSeguro = true;
            Nodos[15].EsSeguro = true;
        }

        public Nodo ObtenerNodo(int id)
        {
            return Nodos.ContainsKey(id) ? Nodos[id] : null;
        }
    }
}