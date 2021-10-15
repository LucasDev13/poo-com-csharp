using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_bytebank
{
    public class ContaCorrente
    {
        public String titular;
        public int agencia;
        public int numero;
        public double saldo;
        
        public bool sacar(double valor){
            if(this.saldo < valor){
                return false;
            }else{
                this.saldo -= valor;
                return true;
            }
        }
    }
}