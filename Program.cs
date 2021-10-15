using System;

namespace poo_bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente1 contaDaGabriela = new ContaCorrente1();
            ContaCorrente2 contaDaGabriela = new ContaCorrente2();

            contaDaGabriela.titular = "Gabriela";

            Console.WriteLine("Titular: " + contaDaGabriela.titular);
            Console.WriteLine("Agencia: " + contaDaGabriela.agencia);
            Console.WriteLine("Numero: " + contaDaGabriela.numero);
            Console.WriteLine("Saldo: " + contaDaGabriela.saldo);

            contaDaGabriela.saldo += 200;
            Console.WriteLine("Debitado no saldo 200: " + "Saldo = "+ contaDaGabriela.saldo);
        }
    }
}
