using System.Collections.Generic;

namespace fichaParchis
{
    public class NodoDecision
    {
        public string Accion { get; set; }
        public List<NodoDecision> Opciones { get; set; }

        public NodoDecision(string accion)
        {
            Accion = accion;
            Opciones = new List<NodoDecision>();
        }

        public void AgregarOpcion(NodoDecision opcion)
        {
            Opciones.Add(opcion);
        }
    }
}