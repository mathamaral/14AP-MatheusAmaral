using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Polimorfismo
{
    class Program
    {
         static void Main(string[] args)
        {
        MeioTransporte c = new Carro();
        c.Modelo = "Ferrari";
        c.Mover();

        MeioTransporte a = new Aviao();
        a.Modelo = "Boing 157";
        a.Mover();
        Console.ReadLine();
        }
    }
}