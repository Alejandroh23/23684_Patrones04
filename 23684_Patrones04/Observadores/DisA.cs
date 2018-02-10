using System;
namespace _Patrones04.Observadores
{
    public class DisA : Move, Muestreo
    {
        public DisA()
        {
        private double presion;
        private double humedad;
        private double temperatura;

        @override

            public void actualizar(Double presion, Double humedad, Double temperatura);
            this.humedad = humedad;
            this.temperatura = temperatura;
            this.presino = presion;
            this.muestra();
    }
    override
        public void muestra(){
            Console.WriteLine("DisplayA");
            Console.WriteLine(this.humedad);
            Console.WriteLine(this.temperatura);
            Console.WriteLine(this.presion);

        }
    }
}
