using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej2
{
    public class Controlador
    {
        /// <summary>
        /// Calcula el perimetro del circulo con centro ("pX","pY") y radio "pRadio".
        /// </summary>
        /// <param name="pX"></param>
        /// <param name="pY"></param>
        /// <param name="pRadio"></param>
        /// <returns></returns>
        public static double CalcularPerimetro(double pX,double pY,double pRadio)
        {
            return (new Circulo(pX, pY, pRadio)).CalcularPerimetro();
        }

        /// <summary>
        /// Calcula el area del circulo con centro ("pX","pY") y radio "pRadio".
        /// </summary>
        /// <param name="pX"></param>
        /// <param name="pY"></param>
        /// <param name="pRadio"></param>
        /// <returns></returns>
        public static double CalcularArea(double pX, double pY, double pRadio)
        {
            return (new Circulo(pX, pY, pRadio)).CalcularArea();
        }

        /// <summary>
        /// Calcula el perimetro del triangulo cuyos puntos son ("p1X',"p1Y"), ("p2X","p2Y") y ("p3X","p3Y").
        /// </summary>
        /// <param name="p1X"></param>
        /// <param name="p1Y"></param>
        /// <param name="p2X"></param>
        /// <param name="p2Y"></param>
        /// <param name="p3X"></param>
        /// <param name="p3Y"></param>
        /// <returns></returns>
        public static double CalcularPerimetro(double p1X, double p1Y, double p2X, double p2Y, double p3X, double p3Y)
        {
            return (new Triangulo(p1X, p1Y, p2X,  p2Y,  p3X,  p3Y)).CalcularPerimetro();
        }

        /// <summary>
        /// Calcula el area del triangulo cuyos puntos son ("p1X',"p1Y"), ("p2X","p2Y") y ("p3X","p3Y").
        /// </summary>
        /// <param name="p1X"></param>
        /// <param name="p1Y"></param>
        /// <param name="p2X"></param>
        /// <param name="p2Y"></param>
        /// <param name="p3X"></param>
        /// <param name="p3Y"></param>
        /// <returns></returns>
        public static double CalcularArea(double p1X, double p1Y, double p2X, double p2Y, double p3X, double p3Y)
        {
            return (new Triangulo(p1X, p1Y, p2X, p2Y, p3X, p3Y)).CalcularArea();
        }
    }
}
