# Projeto para exercitar tratamento de exception - balta.io 

- Simula erro de index of, no array para tratamento com exception;

- Inicia capítulo Try / Catch
    - Trata uma exception de forma simples e básica. Há nível de mensagem apenas; 
    - Finaliza a aula de Try / Catch;

- Inicia capítulo Tratando erros
    - Informações adicionais
    É possível utilizar vários catch;
    Os erros devem ser tratados sempre de um modo mais específico para o mais genérico.
    por exemplo:

    catch (IndexOutOfRangeException ex)
    {
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
        Console.WriteLine("Não encontrei o índice na lista");
    }
    catch (Exception ex)
    {
        Console.WriteLine("Ops, algo deu errado!");
                
        //Adiciona informações da exception
        Console.WriteLine(ex.InnerException);
        Console.WriteLine(ex.Message);
    }

    IndexOutOfRangeException é do tipo Exception, ou seja, uma extensão do tipo básico Exception.
    Desta forma, é possível tratar de forma mais específica, para a mais genérica.