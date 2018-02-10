using System;
namespace _Patrones04.Observadores
{
    public interface Move
    {
        void actualizar(Double presion, Double temperatura, Double humedad);
    }
}
