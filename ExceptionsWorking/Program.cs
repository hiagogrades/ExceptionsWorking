using System;
using System.Runtime.Serialization.Formatters;

namespace ExceptionsWorking
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Todos os erros no dotnet são tratados como exceptions
            var arr = new int[3];


            //O bloco de código abaixo, irá tentar executar todo o código contido no seu corpo.
            //Caso aconteça algum erro, a mensagem é exibida 
            try
            {
                //System.IndexOutOfRangeException:
                //Erro de exception ao executar propositalmente o código errado.
                for (var index = 0; index < 10; index++)
                {
                    Console.WriteLine(arr[index]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Ops, algo deu errado!");
                
                //Adiciona informações da exception
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
            }
            
        }
    }
}
