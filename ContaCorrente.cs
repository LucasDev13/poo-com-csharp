using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_bytebank
{
    public class ContaCorrente
    {
        public Cliente Titular {get; set;}
        public int Agencia {get; set;}
        public int Numero {get; set;}

        //propriedade que vai ser compartilhada com todos os objetos.
        public static int TotalDeContasCriadas{get; private set;}
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

        //Colocar informações obrigatórias no construtor é uma prático de programação defensiva.
        //Evita cometer erros no código. Nunca terei um conta sem agencia e numero, serão sempre obrigatórios.
        public ContaCorrente(int agencia, int numero){
            Agencia = agencia;
            Numero = numero;
            //propriedade que vai ser compartilhada com todos os objetos. Vai chamar o construtor cada vez que o objeto for criado.
            TotalDeContasCriadas++;
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