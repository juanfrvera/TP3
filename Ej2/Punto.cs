using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej2
{
    class Punto
    {
        //Atributos
        private double iX;
        private double iY;
        
        //Propiedades
        public double X
        {
            get { return this.iX; }
            private set { this.iX = value; }
        }
        public double Y
        {
            get { return this.iY; }
            private set { this.iY = value; }
        }

        //Constructores

            /// <summary>
            /// Construye el punto cuya componente en X es "pX" y su componente en Y es "pY".
            /// </summary>
            /// <param name="pX"></param>
            /// <param name="pY"></param>
        public Punto(double pX, double pY)
        {
            this.X = pX;
            this.Y = pY;
        }

        //Metodos

            /// <summary>
            /// Calcula la distancia entre este si mismo y el punto "pPunto".
            /// </summary>
            /// <param name="pPunto"></param>
            /// <returns></returns>
        public double CalcularDistanciaDesde(Punto pPunto)
        {
            //Distancia euclidiana
            return Math.Sqrt(Math.Pow(this.X - pPunto.X, 2) + Math.Pow(this.Y - pPunto.Y, 2));
        }
    }
}