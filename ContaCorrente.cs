using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_bytebank
{
    public class ContaCorrente
    {
        public Cliente titular;
        public int agencia;
        public int numero;
        private double saldo;
        
        public void DefinirSaldo(double saldo){
            if(saldo < 0){
                return;
            }
            this.saldo = saldo;
        }

        public double ObterSaldo(){
            return saldo;
        }

        public bool Sacar(double valor){
            if(this.saldo < valor){
                return false;
            }
            this.saldo -= valor;
            return true;
        }
        public void Depositar(double valor){
            this.saldo += valor;
        }

        public Boolean Transferir(double valor, ContaCorrente contaDestino){
            if (this.saldo < valor){
                return false;
            }
            this.saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}