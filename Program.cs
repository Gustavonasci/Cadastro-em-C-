using System;

namespace Aula03
{
    class Program
    {
        static void Main()
        {
            string nome, cpf, end;
            int cep, idade ;
            Console.WriteLine("==============PREENCHA COM SEU DADOS AS SEGUINTES INFORMAÇÔES.==============");
            Console.WriteLine("========================PREENCHA SEU NOME.==================================");
            nome = Console.ReadLine();
            Console.WriteLine("========================PREENCHA SEU CPF.===================================");
            cpf = Console.ReadLine();
            Console.WriteLine("========================PREENCHA SEU ENDEREÇO.==============================");
            end = Console.ReadLine();
            Console.WriteLine("========================PREENCHA SUA IDADE.=================================");
            idade = Convert.ToInt32  (Console.ReadLine());
            Console.WriteLine("========================PREENCHA SEU CEP.===================================");
            cep = Convert.ToInt32 (Console.ReadLine());

            Console.WriteLine($"==============SEU CADASTRO ESTÁ OK, CONFIRME AS INFORMAÇÔES=============");

        
            Console.WriteLine($"NOME COMPLETO: {nome}");

            Console.WriteLine($"SEU CPF: {cpf}");

            Console.WriteLine($"SUA IDADE É: {idade} ANOS");

            Console.WriteLine($"SEU ENDEREÇO: {end}");

            Console.WriteLine($"SEU CEP: {cep}");
            

        }
    }
}
