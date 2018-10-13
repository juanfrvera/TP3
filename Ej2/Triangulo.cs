using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej2
{
    class Triangulo : Figura
    {
        //Atributos
        private Punto iPunto1;
        private Punto iPunto2;
        private Punto iPunto3;

        //Propiedades
        public Punto Punto1
        {
            get { return this.iPunto1; }
            private set { this.iPunto1 = value; }
        }
        public Punto Punto2
        {
            get { return this.iPunto2; }
            private set { this.iPunto2 = value; }
        }
        public Punto Punto3
        {
            get { return this.iPunto3; }
            private set { this.iPunto3 = value; }
        }
        //Lado desde el punto 1 al 2
        private double LadoA
        {
            get { return Punto2.CalcularDistanciaDesde(Punto1); }
        }
        //Lado desde el punto 2 al 3
        private double LadoB
        {
            get { return Punto3.CalcularDistanciaDesde(Punto2); }
        }
        //Lado desde el punto 3 al 1
        private double LadoC
        {
            get { return Punto1.CalcularDistanciaDesde(Punto3); }
        }
        /// <summary>
        /// Calcula el perimetro como la suma de sus lados.
        /// </summary>
        /// <returns></returns>
        public override double CalcularPerimetro()
        {
            return LadoA + LadoB + LadoC; 
        }

        /// <summary>
        /// Calcula el area aplicando la formula de Heron.
        /// </summary>
        /// <returns></returns>
        public override double CalcularArea()
        {
            double s = CalcularPerimetro() / 2;
            return Math.Sqrt(s*(s-LadoA)*(s-LadoB)*(s-LadoC));
        }

        //Constructores

            /// <summary>
            /// Construye el triangulo cuyos puntos son "pPunto1", "pPunto2" y "pPunto3".
            /// </summary>
            /// <param name="pPunto1"></param>
            /// <param name="pPunto2"></param>
            /// <param name="pPunto3"></param>
        public Triangulo(Punto pPunto1, Punto pPunto2, Punto pPunto3)
        {
            this.Punto1 = pPunto1;
            this.Punto2 = pPunto2;
            this.Punto3 = pPunto3;
        }

        /// <summary>
        /// Construye el triangulo cuyos puntos son ("p1X',"p1Y"), ("p2X","p2Y") y ("p3X","p3Y").
        /// </summary>
        /// <param name="p1X"></param>
        /// <param name="p1Y"></param>
        /// <param name="p2X"></param>
        /// <param name="p2Y"></param>
        /// <param name="p3X"></param>
        /// <param name="p3Y"></param>
        public Triangulo(double p1X, double p1Y, double p2X, double p2Y, double p3X, double p3Y) : 
            this(new Punto(p1X, p1Y), new Punto(p2X, p2Y), new Punto(p3X, p3Y)) { }
    }
}