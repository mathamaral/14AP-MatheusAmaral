using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Encapsulamento
{
    public class Motor{}
    }
    public class Bateria
    {
    }
    public class Carro
    {
    // Encapsulando Detalhes
    //Composição
    private Motor _motor;
    private Bateria _bateria;
    private string _nome;
    public string Nome
    {
        get {
        return _nome;
            }
    }
    private void Ignicao()
    {
        Console.WriteLine("Foi dada a Ignicao do Carro");
    }
     public int NumPneus()
    {
        return 4;

    }
    //Construtor
    public Carro(string nome)
    {

    }
        Console.WriteLine("Criando objeto Carro");
        _motor = new Motor();
        _bateria = new Bateria();
        _nome = nome;
    }
    public void Ligar()
    {
        Console.WriteLine("Ligando o carro");
        Ignicao();
    }
    public void Mover()
    {
        Console.WriteLine("Movendo o carro");
    }
    public void Abastecer()
    {
        Console.WriteLine("Abastecendo o carro");
    }
    }
}