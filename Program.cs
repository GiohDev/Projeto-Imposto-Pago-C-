using Projeto_PessoaFisica_PessoaJuridica.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;


namespace Projeto_PessoaFisica_PessoaJuridica {
    internal class Program {
        static void Main(string[] args) {

            CultureInfo CI = CultureInfo.InvariantCulture;
            List<Contribuinte> contribuintes = new List<Contribuinte>();

            Console.Write("Digite o numero de contribuintes: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Contribuinte #"+(i+1)+" dados:");

                Console.Write("Pessoa fisica ou juridica (f/j)? ");
                char type = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();

                Console.Write("Renda Anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(),CI);
                 
                if (type == 'f') {
                    Console.Write("Gastos com saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine(),CI);
                    PessoaFisica pessoaFisica = new PessoaFisica(nome , rendaAnual , gastosSaude);
                    contribuintes.Add(pessoaFisica);

                }else {
                    Console.Write("Numero de Funcionarios: ");
                    int numeroDeFuncionarios = int.Parse(Console.ReadLine());   
                    PessoaJuridica pessoaJuridica = new PessoaJuridica(nome, rendaAnual , numeroDeFuncionarios);
                    contribuintes.Add(pessoaJuridica);
                }
            }


            Console.WriteLine("Impostos pagos: ");
            double impostoTotal = 0.0;

            foreach(Contribuinte c in contribuintes) {
                Console.WriteLine(c.Nome + ": $ " + c.ImpostoPago().ToString("F2",CI));
                impostoTotal += c.ImpostoPago();
            }


            Console.Write("Total dos Impostos: " + impostoTotal.ToString("F2",CI));

        }
    }
}
