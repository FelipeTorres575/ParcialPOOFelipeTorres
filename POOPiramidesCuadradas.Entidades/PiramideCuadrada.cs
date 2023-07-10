using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOPiramidesCuadradas.Entidades
{
    public class PiramideCuadrada
    {
        private double Lado;
        private double Altura;
        private double Arista;

        public double Area;
        public double Volumen;

        public PiramideCuadrada(double lado, double altura)
        {
            Lado = lado;
            Altura = altura;
            Area = GetArea();
            Volumen = GetVolumen();
        }

        public double GetArista()
        {
            return Math.Sqrt(Math.Pow(Altura, 2) + Math.Pow(Lado, 2) / 2);
        }

        public double GetArea()
        {
            return Lado * (Lado + Math.Sqrt(4 * Math.Pow(Altura, 2) + Math.Pow(Lado, 2)));
        }

        public double GetVolumen()
        {
            return (Math.Pow(Lado, 2) * Altura) / 3;
        }

        public override string ToString()
        {
            return $"Lado={Lado},Arista={Arista}, Altura={Altura} ,Area={Area}, Volumen={Volumen}";
        }

    }
}
