using System;
namespace _Patrones04.Observadores
{
    public class DisB : Move, Muestreo
    {
        public DisB()
        {
        private double presion;
        private double temperatura;

        @override

            public void actualizar(Double presion, Double humedad, Double temperatura);
            this.temperatura = temperatura;
            this.presino = presion;
            this.muestra();
    }
    override
        public void muestra()
    {
        Console.WriteLine("DisplayB");
        Console.WriteLine(this.temperatura);
        Console.WriteLine(this.presion);

         }
    }
}