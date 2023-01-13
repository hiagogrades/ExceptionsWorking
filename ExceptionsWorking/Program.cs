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

            //System.IndexOutOfRangeException:
            //Erro de exception ao executar propositalmente o código errado.
            for (var index = 0; index < 10; index++)
            {
                Console.WriteLine(arr[index]);
            }
        }
    }
}
