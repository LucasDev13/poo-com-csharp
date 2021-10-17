using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace poo_bytebank
{
    public class Cliente{

        private string _cpf;

        public string Nome {get; set;}  
        public string CPF { 
            get{
                return _cpf;
            }
            
            set{
                //escrever a lógica de validação do cpf;
            } 
        }
        public string Profissao {get; set;}
        
    }
}