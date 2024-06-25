using System;
using System.Collections.Generic;
using System.Text;

namespace Projeto_PessoaFisica_PessoaJuridica.Entidades {
    internal class PessoaJuridica : Contribuinte {

        public int NumeroDeFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroDeFuncionarios)
         : base ( nome , rendaAnual)   {
            NumeroDeFuncionarios = numeroDeFuncionarios;
        }

        public override double ImpostoPago() {
            if (NumeroDeFuncionarios < 10) {
                return RendaAnual * 0.16;
            }
            else {
                return RendaAnual * 0.14;
            }
        }


    }
}
