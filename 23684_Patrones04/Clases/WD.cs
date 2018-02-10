using System;
namespace _Patrones04.Clases
{
    public class WD : Clase
    {
        public WD()
        {
            private List<Move> moves = new List<Move>();
        private double humedad;
        private double presion;
        private double temperatura;

        private void measurementsChanged()
        {
            for (Move move: moves)
            {
                notify(move);
            }
        }

        public void Medidas(double presion, double humedad, double humedad);
        {
            this.presion = presion;
            this.humedad = humedad;
            this.temperatura = temperatura;

            CambiosEnMedidas();
        }

            override
    public void remove(Move move)
        {
            this.moves.remove(move);
        }

            override
    public void add(Move move)
        {
            this.moves.add(move);
        }


            override
    public void notify(Move move)
        {
            move.modificar(this.presion, this.humedad, this.temperatura);
        }
    }
}