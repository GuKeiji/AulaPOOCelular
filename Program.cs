using System;

namespace AtividadeSistemaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            Celular Iphone = new Celular();
            Iphone.cor = "Preto";
            Iphone.modelo = "Iphone 7";
            Iphone.tamanho = 4.7f;
            Iphone.ligado = false;
            string selecionar1 = "";
            int selecionar2 = 0;

            Console.WriteLine($@"
    Modelo: {Iphone.modelo}
    Cor: {Iphone.cor}
    Tamanho: {Iphone.tamanho} polegadas
    
            +---------+
            |         |
            |         |
            |         |
            |         |
            |         |
            |         |
            |---------|
            |   ( )   |
            +---------+ 

    Deseja ligar o {Iphone.modelo}? (s/n)
            ");
            selecionar1 = Console.ReadLine().ToLower();
            if (selecionar1 == "s")
            {
                Iphone.Ligar();
            }
            while (Iphone.ligado == true)
            {

                Console.WriteLine($@"
    
            O {Iphone.modelo} evoluiu para um Ipad!

            +---------------------+
            |                     |
            |   Olá               |
            |  1-Enviar SMS       |
            |  2-Fazer uma Ligação|
            |  3-Desligar         |
            |                     |
            | Selecione uma opção |
            |                     |
            |---------------------|
            |         ( )         |
            +---------------------+ 

            ");
                selecionar2 = int.Parse(Console.ReadLine());
                if (selecionar2 == 1)
                {
                    Console.WriteLine(@"Digite o contato:
Odirlei
Thiago
Eu
Gustavos
                    ");
                    string contato = Console.ReadLine();

                    Console.WriteLine("Digite a mensagem:");
                    string sms = Console.ReadLine();
                    Console.WriteLine($@"

            +---------------------+
            |                     |
            |    Para: {contato}  |
            |    Sua mensagem:    |
            |    {sms}            |
            |                     |
            |    {Iphone.EnviarMensagem()}|
            |                     |
            |                     |
            |---------------------|
            |         ( )         |
            +---------------------+ 

            ");

                }
                else if (selecionar2 == 2)
                {
                    Console.WriteLine(@"Digite o contato:
Odirlei
Thiago
Eu
Gustavos
                    ");
                    string contato = Console.ReadLine();
                    Console.WriteLine($@"

            +---------------------+
            |                     |
            |    Para: {contato}  |
            |                     |
            |    {Iphone.FazerLigacao()}|
            |                     |
            |                     |
            |                     |
            |                     |
            |---------------------|
            |         ( )         |
            +---------------------+ 

            ");
                }
                else
                {
                    Iphone.Desligar();
                }
            }
        }
    }
}

