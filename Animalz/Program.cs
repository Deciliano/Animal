using ConsoleApp2;
using System.Security.Cryptography.X509Certificates;

public static class Program
{
    public static void Main(string[] args)
    {
        var a = new Ave();
        a.locomover();
        a.alimentar();
        a.emitirSom();
        
        var m = new Mamifero();

        m.alimentar();
        m.locomover();
        m.emitirSom();

    }
}