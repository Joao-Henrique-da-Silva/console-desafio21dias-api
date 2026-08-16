using System;
using System.Collections.Generic;

namespace Desafio21Dias_API_CCharp
{

class Program
{
    
    static void Main(string[] args)
    {


        /*
        Daniel é um agricultor e precisa de um programa que ao digitar o número inicial 1 e final 10, o programa mostra repetidamente
        todos os números na tela
        */

        //Console.WriteLine("Digite o número inicial");
        //var numeroInicial = Convert.ToInt32(Console.ReadLine());

        //Console.WriteLine("Digite o número final");
        //int numeroFinal = Convert.ToInt32(Console.ReadLine());

        //int indice = numeroInicial;
        //while(indice <= numeroFinal)

        //{
        //    Console.WriteLine(indice);
        //    indice++;
        //}
        
        //for(int i = numeroInicial; i <= numeroFinal; i++ )
        //{
        //    Console.WriteLine(i);
        //}

        //int[] itens = new int[]{1,2,3,4,5,6,7,8,9,10,11,12,13};
        //foreach(int item in itens)
        //{
        //    Console.WriteLine(item);
        //}

        // while(true)
        // {
        //     Console.WriteLine("Digite\n1 - para sair\n0 - para continuar");
        //     int sair = Convert.ToInt32(Console.ReadLine());
        //     if (sair == 1) break;
        //     else if(sair == 2) continue;

        //     Console.WriteLine("Opaaa, ainda estou aqui");
        //     Console.WriteLine("Hey, I'm still here");
        //     Console.WriteLine("Holla, estoy aqui");
        // }

        // List <dynamic> alunos = new List <dynamic>();
        // alunos.Add(new{
        //     Nome = "João Henrique",
        //     Matricula = "1001",
        //     Notas = "7, 8, 9, 10"
        // });

        // alunos.Add(new{
        //     Nome = "Danilo",
        //     Matricula = "1002",
        //     Notas = "10, 9, 10, 9"
        // });

        // alunos.Add(new{
        //     Nome =  "José",
        //     Matricula = "1003",
        //     Notas = "10, 9, 9, 10"
            
        // });

        // foreach(var aluno in alunos)
        // {
        //     Console.WriteLine("-------------------");
        //     Console.WriteLine($"Nome: {aluno.Nome}");
        //     Console.WriteLine($"Matricula: {aluno.Matricula}");
        //     Console.WriteLine($"Nome: {aluno.Notas}");
        // }

        /* Valkiria é a diretora da escola Mundo Melhor
        Ela precisa de um progrma que armazene nomes, matricula e notas de seus alunos em uma tabela
        e ao final que a média seja  calculada e que apresente a média de cada aluno com seus dados 
        respectivos e a mensagem de aprovação ou reprovação
        */

            
            Console.WriteLine("Bem-vinda, Valkiria!\n");

            var Opcao = "s";
            var Nome = "";
            var Matricula = "";
            var resultado = "";
            List<dynamic> alunos =  new List<dynamic>();
            while (Opcao.ToLower() == "s")
            {
                Console.WriteLine("Digite o nome do aluno:");
                Nome = Console.ReadLine(); 
                Console.WriteLine("Digite a matrícula do aluno:");
                Matricula =  Console.ReadLine();
                Console.WriteLine("Digite a nota do aluno:");
                double[] notas = new double[3];
                double soma = 0;
                double media = 0;
                for (int i = 0; i < 3; i++) 

                {
                    Console.WriteLine($"{i + 1}ª nota:");
                    notas[i] = Convert.ToDouble(Console.ReadLine());
                    soma += notas [i];
                }
                media = soma/notas.Length;
                if (media >= 7)
                {
                    resultado = "Aprovado";
                }
                else
                {
                    resultado = "Reprovado";
                }
            alunos.Add(new{
                Nome = Nome,
                Matricula = Matricula,
                Notas = notas,
                Media = media, 
                Situação = resultado
            });

            
            Console.WriteLine("cadastrar outro aluno s/n");
            Opcao = Console.ReadLine();
            }

            Console.Clear();
            foreach(var aluno in alunos)
            {
                Console.WriteLine("____________________");
                Console.WriteLine($"Nome: {aluno.Nome} - Matricula: {aluno.Matricula}");
                Console.WriteLine("____________________");
                Console.WriteLine($"Notas:");
                int n = 1;
                foreach(double nota in aluno.Notas)
                {
                    Console.WriteLine($"{n}º nota: {nota}");
                    n += 1;
                }
                Console.WriteLine($"Média: {Math.Round(aluno.media,1)} - Situação: {aluno.Situação}");

            }
                Console.WriteLine("________________________");
        return;
    }
}

}
