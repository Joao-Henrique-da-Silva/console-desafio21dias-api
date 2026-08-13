using System;

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

        List <dynamic> alunos = new List <dynamic>();
        alunos.Add(new{
            Nome = "João Henrique",
            Matricula = "1001",
            Notas = "7, 8, 9, 10"
        });

        alunos.Add(new{
            Nome = "Danilo",
            Matricula = "1002",
            Notas = "10, 9, 10, 9"
        });

        alunos.Add(new{
            Nome =  "José",
            Matricula = "1003",
            Notas = "10, 9, 9, 10"
            
        });

        foreach(var aluno in alunos)
        {
            Console.WriteLine("-------------------");
            Console.WriteLine($"Nome: {aluno.Nome}");
            Console.WriteLine($"Matricula: {aluno.Matricula}");
            Console.WriteLine($"Nome: {aluno.Notas}");
        }


        return;
    }
}
