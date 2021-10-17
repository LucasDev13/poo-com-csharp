using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_bytebank
{
    public class ContaCorrente
    {
        public Cliente titular {get; set;}
        public int agencia {get; set;}
        public int numero {get; set;}
        private double _saldo;

        //Propriedade Saldo com S maiúsculo, convensão de nomes de propriedades;
        public double Saldo{
            get{
                return _saldo;
            }
            set{
                if(value < 0){
                    return;
                }
                _saldo = value;
            }
        }
        /**public void SetSaldo(double saldo){
            if(saldo < 0){
                return;
            }
            this.saldo = saldo;
        }

        public double GetSaldo(){
            retur*/

        public bool Sacar(double valor){
            if(this._saldo < valor){
                return false;
            }
            this._saldo -= valor;
            return true;
        }
        public void Depositar(double valor){
            this._saldo += valor;
        }

        public Boolean Transferir(double valor, ContaCorrente contaDestino){
            if (this._saldo < valor){
                return false;
            }
            this._saldo -= valor;
            contaDestino.Depositar(valor);
            return true;
        }
    }
}