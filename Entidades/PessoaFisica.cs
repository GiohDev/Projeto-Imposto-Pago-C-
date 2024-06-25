using System;
using System.Collections.Generic;
using System.Text;
using Projeto_PessoaFisica_PessoaJuridica.Entidades;

namespace Projeto_PessoaFisica_PessoaJuridica.Entidades {
    class PessoaFisica : Contribuinte {

        public double GastosSaude { get; set; }

        public PessoaFisica (string nome, double rendaAnual , double gastosSaude) 
            : base (nome , rendaAnual){
            GastosSaude = gastosSaude;
        }


        public override double ImpostoPago() {
           double Imposto = 0.0;
           if (RendaAnual < 20000.00) {
                Imposto += 0.15;

            }else {
                Imposto += 0.25;
            }

            return RendaAnual * Imposto - GastosSaude * 0.50;
                
        }
    }


}
