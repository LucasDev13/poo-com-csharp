using System;

namespace poo_bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente1 contaDaGabriela = new ContaCorrente1();
            //ContaCorrente2 contaDaGabriela = new ContaCorrente2();
            ContaCorrente3 contaDaGabriela = new ContaCorrente3();

            contaDaGabriela.saldo = 200;
            Console.WriteLine(contaDaGabriela.saldo);

            contaDaGabriela.saldo += 100;
            Console.WriteLine(contaDaGabriela.saldo);

            ContaCorrente3 contaDaGabrielaCosta = new ContaCorrente3();
            contaDaGabrielaCosta.saldo = 50;

            Console.WriteLine("Saldo grabriela: "+contaDaGabriela.saldo);
            Console.WriteLine("Saldo grabriela costa: "+contaDaGabrielaCosta.saldo);

            contaDaGabriela = contaDaGabrielaCosta;
            Console.WriteLine("Saldo grabriela: "+contaDaGabriela.saldo);
            
        }
    }
}
