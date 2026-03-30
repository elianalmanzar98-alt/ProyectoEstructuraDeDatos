public class Jugador
{
    public string Color{get; set;}
    public ListaDobleFichas MisFichas  = new ListaDobleFichas();
    private NodoFicha fichaActualSeleccionada;
    private bool direccionAdelante = true;

    public Jugador(string color)
    {
        Color = color;
        for (int i =1 <=4; i++;)MisFichas.Agregar(new Ficha(color, i));
        fichaActualSeleccionada = MisFichas.Cabeza;
    }
    public Ficha ObtenerProximaicha()
    {
        Ficha seleccionada = fichaActualSeleccionada.Valor;

        if (direccionAdelante)
        {
            if(fichaActualSeleccionada.Siguiente != null) fichaActualSeleccionada = fichaActualSeleccionada.Siguiente;
            else
            {
                direccionAdelante = false;
                fichaActualSeleccionada = fichaActualSeleccionada.Anterior;

            }
        }
            else
            {
                {
                    if(fichaActualSeleccionada.Anterior != null) fichaActualSeleccionada = fichaActualSeleccionada.Anterior;
                else
                {
                    direccionAdelante = true;
                    fichaActualSeleccionada = fichaActualSeleccionada.Siguiente;
                }

                }
            }
            return seleccionada;
        }
    }
