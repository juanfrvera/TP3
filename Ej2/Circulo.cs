using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej2
{
    class Circulo : Figura
    {
        //Atributos
        private Punto iCentro;
        private double iRadio;
        //Propiedades
        public Punto Centro
        {
            get { return this.iCentro; }
            private set { this.iCentro = value; }
        }
        public double Radio
        {
            get { return this.iRadio; }
            private set { this.iRadio = value; }
        }
        public override double CalcularPerimetro()
        {
            return 2 * Math.PI * Radio;
        }
        public override double CalcularArea()
        {
            return Math.PI * Math.Pow(Radio, 2);
        }
        //Constructores

        /// <summary>
        /// Construye el circulo de centro "pCentro" y radio "pRadio".
        /// </summary>
        /// <param name="pCentro"></param>
        /// <param name="pRadio"></param>
        public Circulo(Punto pCentro, double pRadio)
        {
            this.Centro = pCentro;
            this.Radio = pRadio;
        }

        /// <summary>
        /// Construye el circulo cuyo centro es el punto ("pX","pY") y su radio es "pRadio".
        /// </summary>
        /// <param name="pX"></param>
        /// <param name="pY"></param>
        /// <param name="pRadio"></param>
        public Circulo(double pX, double pY, double pRadio) : this(new Punto(pX, pY), pRadio) {}
        
    }
}
