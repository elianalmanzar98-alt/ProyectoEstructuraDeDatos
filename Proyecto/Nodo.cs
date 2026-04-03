using System.Collections.Generic;

namespace fichaParchis
{
    public class Nodo
    {
        public int Id { get; set; }
        public bool EsSeguro { get; set; }
        public bool EsMeta { get; set; }

        public List<Nodo> Siguientes { get; set; }

        public Nodo(int id)
        {
            Id = id;
            Siguientes = new List<Nodo>();
        }

        public void Conectar(Nodo nodo)
        {
            Siguientes.Add(nodo);
        }
    }
}