using System;

namespace poo_bytebank
{
    class Program
    {
        static void Main(string[] args)
        {
            //ContaCorrente1 contaDaGabriela = new ContaCorrente1();
            //ContaCorrente2 contaDaGabriela = new ContaCorrente2();
            ContaCorrente contaCorrente1= new ContaCorrente();

            contaCorrente1.saldo = 200;
            Console.WriteLine(contaCorrente1.saldo);

            contaCorrente1.saldo += 100;
            Console.WriteLine(contaCorrente1.saldo);

            ContaCorrente contaCorrente2 = new ContaCorrente();
            contaCorrente2.saldo = 50;

            Console.WriteLine("Saldo grabriela - conta corrente 1: "+contaCorrente1.saldo);
            Console.WriteLine("Saldo grabriela costa - conta corrente 2: "+contaCorrente2.saldo);

            contaCorrente1 = contaCorrente2;
            Console.WriteLine("Saldo grabriela: "+contaCorrente1.saldo);

            contaCorrente1.Sacar(50);
            Console.WriteLine("Saldo conta corrente 1: " + contaCorrente1.saldo);

            contaCorrente1.Depositar(100);
            Console.WriteLine("Saldo da conta 1 - gabriela: " + contaCorrente1.saldo);
            
        }
    }
}
