using POOPiramidesCuadradas.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOPiramidesCuadradas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            PiramideCuadrada pc = new PiramideCuadrada(2,4);
            
            Console.WriteLine(pc.ToString());
        }
    }
}
