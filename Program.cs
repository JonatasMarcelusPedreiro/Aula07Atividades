using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula07Atividades
{
    class Program
    {
        static void Main(string[] args)
        {
            // Atividade 04 //












            // Atividade 03 //
            string nome;
            int nota1;
            int nota2;
            int media = (10);
            

            Console.WriteLine(" Olá, esse é o sistema para saber se você foi aprovado ou não");
            Console.WriteLine(" Para saber a sua média digite seu nome:");
            nome = Console.ReadLine();



            Console.WriteLine($" OK {nome}, Agora digite a sua primeira nota:");
            nota1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine(" Agora dite sua segunda nota:");
            nota2 = int.Parse(Console.ReadLine());

            
            Console.WriteLine($" A medida total foi: {nota1 + nota2 / 2  }  ");
            


            if (nota1 + nota2 / 2 <= 10 && nota1 + nota2 / 2 >= 7) 
            {




                Console.WriteLine(" Você foi aprovado!!");





            } else
            {
                Console.WriteLine(" Você foi reprovado.");




            }
           
            






            
            

               




            








            Console.ReadKey();

            return;
            // Atividade 2 //
            
            int numero1;
            int numero2;
            int divisao;

            Console.WriteLine(" Faça uma divisão: ");
            Console.WriteLine(" Digite o primeiro número");
            numero1 = int.Parse(Console.ReadLine());


            Console.WriteLine(" Digite o segundo número ");
            numero2 = int.Parse(Console.ReadLine());

            Console.WriteLine($" O resulto da divisão desses dois números é: {numero1 / numero2}");



            Console.ReadKey();




            return;
            // Atividade 1 //
            int numero;

            Console.WriteLine(" Olá, esse é presente especial da nubank");
            Console.WriteLine(" Digite um valor:");
            numero = Int32.Parse(Console.ReadLine());

            if ( numero >= 100)
            {
                Console.WriteLine(" Ok, o número é maior ou igual a 100, vamos adicionar mais 150 reais");
                Console.WriteLine($" Agora você tem um total de {numero + 150} reais!");   




            }else
            {
                Console.WriteLine(" Que pena, Esse valor é menor que 100");



            }



            Console.ReadKey();

            return;
           



            




        }
    }
}
