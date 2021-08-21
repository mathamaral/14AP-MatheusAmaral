using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Encapsulamento
{
    public class Program
    {
        static void Main(string[] args){
            Carro Ferrari = new Carro();
            Ferrari.Ligar();
            Ferrari.Mover();
            Ferrari.Abastecer();
            Ferrari.Mover();
            Console.ReadLine();
        }
 
    }