using System;
namespace _Patrones04.Observadores
{
    public class DisC : Move, Muestreo
    {
        public DisC()
        {
        private double temperatura;

        @override

            public void actualizar(Double presion, Double humedad, Double temperatura);
            this.temperatura = temperatura;
            this.muestra();
    }
    override
        public void muestra()
    {
        Console.WriteLine("DisplayC");
        Console.WriteLine(this.temperatura);
        

    }
}
}