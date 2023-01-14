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
                //for (var index = 0; index < 10; index++)
                //{
                //    Console.WriteLine(arr[index]);
                //}

                //Simulando um erro com o método Cadastrar
                //Desta forma o sistema irá retornar uma exception pois o texto não pode ser nulo ou vazio.
                Cadastrar("");
            }
            catch (ArgumentNullException ex) 
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Primeira exception");   
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Não encontrei o índice na lista");
            }
            catch (Exception ex)
            {
                //Adiciona informações da exception
                Console.WriteLine(ex.InnerException);
                Console.WriteLine(ex.Message);
                Console.WriteLine("Ops, algo deu errado!");
            }
        }

        private static void Cadastrar(string texto)
        {
            //Simula erro ao "cadastrar" um texto vazio
            if(string.IsNullOrEmpty(texto))
            {
                //Throw = jogar, arremessar
                //Arremessa uma nova exception
                throw new Exception("O texto não pode ser nulo ou vazio");
            }
        }
    }
}
